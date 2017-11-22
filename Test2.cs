using System;

namespace TryCatchFinallyTest
{
    internal static class Test2
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
            finally
            {
                //return "finally";   //Error CS0157  Control cannot leave the body of a finally clause 
            }

            return "method";
        }
    }
}
