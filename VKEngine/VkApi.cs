using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;

namespace Knfa.VK
{
    public class VkApi
    {
        public const String RequestUri = "https://api.vk.com/method/";

        private readonly object _syncRoot;
        private readonly HashSet<Argument> _defaultMethodArguments;

        public VkApi()
        {
            _syncRoot = new object();
            _defaultMethodArguments = new HashSet<Argument>();
        }

        public VkApi(params Argument[] defaultArguments)
            : this()
        {
            _defaultMethodArguments.UnionWith(defaultArguments);
        }

        public bool AddDefaultArgument<T>(string name, T value)
        {
            return AddDefaultArgument(Argument.Create(name, value));
        }

        public bool AddDefaultArgument(Argument argument)
        {
            lock (_syncRoot)
            {
                return _defaultMethodArguments.Add(argument);
            }
        }

        public bool RemoveDefaultArgument(string argumentName)
        {
            lock (_syncRoot)
            {
                return _defaultMethodArguments.RemoveWhere(argument => argument.Name == argumentName) > 0;
            }
        }

        public bool ContainsDefaultArgument(string argumentName)
        {
            lock (_syncRoot)
            {
                return _defaultMethodArguments.FirstOrDefault(argument => argument.Name == argumentName) != null;
            }
        }


        public async Task<TResult> Execute<TResult>(string methodName, params Argument[] args)
        {
            var invokeArgs = _defaultMethodArguments.Concat(args).Distinct();

            var requestString = String.Format("{0}?{1}",
                methodName,
                String.Join("&", invokeArgs.Select(arg => String.Format("{0}={1}", arg.Name, arg.Value))));

            var request = WebRequest.CreateHttp(RequestUri + requestString);

            try
            {
                var response = await Task.Factory.FromAsync<WebResponse>(
                    request.BeginGetResponse,
                    request.EndGetResponse,
                    null);

                using (var responseStream = response.GetResponseStream())
                {
                    var jsonSerializer = new DataContractJsonSerializer(typeof(Response<TResult>));

                    var deserializedObject = jsonSerializer.ReadObject(responseStream) as Response<TResult>;

                    if (deserializedObject != null)
                    {
                        if (deserializedObject.ResponseError != null)
                        {
                            throw new VkApiException {Error = deserializedObject.ResponseError};
                        }

                        return deserializedObject.Result;
                    }

                    throw new VkApiException("Cannot read object from response. Make sure that you use correct return type parameter.");
                }
            }
            catch (WebException e)
            {
                throw new VkApiException(e.Message, e);
            }
        }
    }
}
