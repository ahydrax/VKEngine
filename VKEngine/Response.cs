using System.Runtime.Serialization;

namespace Knfa.VK
{
    /// <summary>
    /// Base class for all VK.com service responses.
    /// </summary>
    [DataContract]
    public sealed class Response<T>
    {
        [DataMember(Name = "response")]
        public T Result { get; set; }

        [DataMember(Name = "error")]
        public ResponseError ResponseError { get; set; }
    }
}
