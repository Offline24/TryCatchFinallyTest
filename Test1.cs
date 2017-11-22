using System;

namespace TryCatchFinallyTest
{
    internal static class Test1
    {
        /// <summary>
        /// Will return "catch"
        /// </summary>
        public static string Test()
        {
            try
            {
                throw new Exception();

                return "try";
            }
            catch
            {
                return "catch";
            }

            return "method";
        }
    }
}
