using System;

namespace ImageDpiChecker
{
    class DpiExceptions : Exception
    {

        public static void InvalidDirectory()
        {
            Console.WriteLine("The given path is invalid, please enter a valid path");
            Console.WriteLine("Press any key to try again...");
            Console.ReadKey();
            Console.Clear();
        }


    }
}
