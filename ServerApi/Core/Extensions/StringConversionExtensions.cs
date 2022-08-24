using System;

namespace ServerApi.Core.Extensions
{
    public static class StringConversionExtensions
    {
        public static bool ToBool(this string str)
        {
            if (str == Constants.True)
            {
                return true;
            }

            return false;
        }

        public static uint ToUint(this string str) => (uint) Int32.Parse(str);
    }
}