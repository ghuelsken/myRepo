using System;

namespace HelloWorld1
{
    class Program
    {

        /*
         * Kommentare können mehrzeilig sein
         */

        static void Main(string[] args)
        {
            //Zeilenkommentar
            String myName = "Gregor";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello World!");
            Console.ReadKey();
            Console.WriteLine("Es wurde der Name \" " + myName + "\" hinterlegt");
            Console.ReadKey();
        }
    }
}
