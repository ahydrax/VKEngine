using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Knfa.VK.Model
{
    [DataContract]
    public sealed class ItemCollection<T>
    {
        [DataMember(Name = "count")]
        public int Count { get; set; }

        [DataMember(Name = "items")]
        public IEnumerable<T> Items { get; set; }
    }
}
