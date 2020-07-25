using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "BoopNet";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 20;

            int num01;
            int num02;
            int num03;
            string name;

            Console.WriteLine("What is your name");

            name = Console.ReadLine();

            Console.WriteLine("Hello " + name + ", nice to meet you!");

            Console.Write("Pick a number: ");
            num01 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Pick another: ");
            num02 = Convert.ToInt32(Console.ReadLine());

            Console.Write("And another: ");
            num03 = Convert.ToInt32(Console.ReadLine());

            int result = (num01 + num02 + num03) / 3;
            Console.Write("Great now i know your name is " + name + " and your number is " + result);


            Console.ReadKey();
        }
    }
}
