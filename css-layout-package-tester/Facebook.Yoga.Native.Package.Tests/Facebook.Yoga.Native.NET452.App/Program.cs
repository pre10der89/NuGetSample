﻿using Facebook.Yoga.Native.Package.Tests;
using System;

namespace Facebook.Yoga.Native.AnyCPU.App
{
    class Program
    {
        static void Main(string[] args)
        {
            bool pause = true;

            if (args != null)
            {
                if (args.Length >= 1)
                {
                    if (args[0] == "/NOPAUSE")
                    {
                        pause = false;
                    }
                }
            }

            TestDriver testDriver = new TestDriver();

            string result;

            bool success = testDriver.RunSanityCheck(out result);

            Console.WriteLine(result);

            if (pause || !success)
            {
                Console.ReadLine();
            }
        }
    }
}
