using System.Runtime.Serialization;

namespace Knfa.VK.Model
{
    [DataContract]
    public sealed class ScreenNameInfo
    {
        [DataMember(Name = "type")]
        public string TypeValue { get; set; }

        [DataMember(Name = "object_id")]
        public int ObjectId { get; set; }

        public ObjectType Type
        {
            get
            {
                switch (TypeValue)
                {
                    case "user":
                        return ObjectType.User;
                    case "group":
                        return ObjectType.Group;
                    case "application":
                        return ObjectType.Applicaton;
                    default:
                        return ObjectType.None;
                }
            }
        }
    }
}
