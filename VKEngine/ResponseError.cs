using System.Runtime.Serialization;

namespace Knfa.VK
{
    /// <summary>
    /// Represents VKApi error.
    /// </summary>
    [DataContract]
    public sealed class ResponseError
    {
        [DataMember(Name = "error_code")]
        public int Code { get; set; }

        [DataMember(Name = "error_msg")]
        public string Message { get; set; }
    }
}
