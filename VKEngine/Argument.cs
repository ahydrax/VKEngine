using System;

namespace Knfa.VK
{
    /// <summary>
    /// Vk.com API method parameter.
    /// </summary>
    public sealed class Argument
    {
        /// <summary>
        /// Gets parameter name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets parameter value.
        /// </summary>
        public object Value { get; private set; }

        private Argument(string name, object value)
        {
            Name = name;
            Value = value;
        }

        public static Argument Create<T>(string name, T value)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("name can't be null or empty string.", "name");
            }

            if (value.Equals(default(T)))
            {
                throw new ArgumentNullException("value", "value can't be null.");
            }

            return new Argument(name, value);
        }

        public override bool Equals(object obj)
        {
            var another = obj as Argument;

            if (another == null)
                return false;

            return Name == another.Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override string ToString()
        {
            return String.Format("{{{0} : {1}}}", Name, Value);
        }
    }
}
