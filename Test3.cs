using System;

namespace TryCatchFinallyTest
{
    internal static class Test3
    {
        /// <summary>
        /// Will return "Start -> Outer try -> Inner try (throw exception) -> Inner catch -> Inner finally -> Outer finally -> End"
        /// </summary>
        public static string Test()
        {
            string result = "Start -> ";

            try
            {
                result += "Outer try -> ";

                try
                {
                    result += "Inner try (throw exception) -> ";

                    throw new Exception();
                }
                catch
                {
                    result += "Inner catch -> ";
                }
                finally
                {
                    result += "Inner finally -> ";
                }
            }
            catch
            {
                result += "Outer catch -> ";
            }
            finally
            {
                result += "Outer finally -> ";
            }


            return result + "End";
        }
    }
}
