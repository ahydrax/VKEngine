using System;
using System.Linq;

namespace Knfa.VK
{
    public static class MethodsHelper
    {
        public static string GetName(this Enum method)
        {
            var scopeName = method.GetType().Name.ToLower();
            var methodName = method.ToString("G");
            var lowerLetter = new string(new[] { methodName[0] }).ToLower();

            return String.Format(
                "{0}.{1}{2}", 
                scopeName,
                lowerLetter,
                methodName.Substring(1)
                );
        }
    }
}
