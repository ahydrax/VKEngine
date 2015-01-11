using System;

namespace Knfa.VK
{
    public sealed class VkApiException : Exception
    {
        public VkApiException()
        {
        }

        public VkApiException(string message) : base(message)
        {
            
        }

        public VkApiException(string message, Exception innerException)
            : base(message, innerException)
        {
            
        }

        public ResponseError Error { get; set; }
    }
}
