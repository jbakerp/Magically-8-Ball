using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Magic_8_Ball
{
    public class Magic8Ball
    {
        public static void Main(string[] args)
        {
            Response anwser = new Response();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to Joe's Super Awesome Magic 8 Ball");
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Ask your question to the Magic 8 Ball: ");
                Console.ResetColor();
                Console.ReadLine();
                anwser.Answer();

            }


        }
    }

}
