using System;
using System.Runtime.Serialization;

namespace Knfa.VK.Model
{
    [DataContract]
    public sealed class UploadServerInfo
    {
        [DataMember(Name = "upload_url")]
        public Uri Uri { get; set; }
    }
}
