using System;

namespace TryCatchFinallyTest
{
    internal static class Test4
    {
        /// <summary>
        /// Will return "Start -> Outer try -> Inner try (throw exception) -> Inner catch (try return) -> Inner finally (throw exception) -> Outer catch -> Return from outer catch"
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
                    result += "Inner catch (try return) -> ";

                    return result + "Return from inner catch";
                }
                finally
                {
                    result += "Inner finally (throw exception) -> ";

                    throw new Exception();
                }
            }
            catch
            {
                result += "Outer catch -> ";

                return result + "Return from outer catch";
            }
            finally
            {
                result += "Outer finally -> ";
            }
        }
    }
}
