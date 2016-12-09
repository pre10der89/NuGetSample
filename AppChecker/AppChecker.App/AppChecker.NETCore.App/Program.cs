using AppChecker.App;
using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string results = "";

            try
            {
                var testDriver = new TestDriver();

                results = testDriver.RunTest();
            }
            catch(Exception ex)
            {
                results = ex.Message + Environment.NewLine + ex.StackTrace;
            }

            Console.WriteLine(results);
            Console.ReadLine();
        }
    }
}


