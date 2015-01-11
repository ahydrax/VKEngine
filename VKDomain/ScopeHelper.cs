using System;

namespace Knfa.VK
{
    public static class ScopeHelper
    {
        public static string CreateString(this Scope scope)
        {
            return scope.ToString("F").Replace(" ", String.Empty).ToLower();
        }

        public static Scope CreateScope(int bitmask)
        {
            var result = (Scope) 0;

            for (var i = 0x1; i < (int)Scope.Stats; i <<= 1)
            {
                if ((bitmask & i) != 0 && Enum.IsDefined(typeof (Scope), i))
                {
                    result |= (Scope) i;
                }
            }

            return result;
        }
    }
}
