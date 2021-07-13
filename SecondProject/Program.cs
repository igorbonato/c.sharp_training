using System;
using System.Globalization;

namespace SecondProject
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 10.35784;
            int age = 22;
            string name = "Igor";
            char w = 'M';
            Console.Write("hello fucking world!"); //sem 'enter'
            Console.WriteLine("Good Morning Vietnammm!");
            Console.WriteLine("See u later."); // com prox linha
            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Result = " + x);
            Console.WriteLine("the amount of change is " + x + " bolsonaros");
            Console.WriteLine("the amount of change is " + x.ToString("F2") + " bolsonaros");
            Console.WriteLine();
            Console.WriteLine("the patient " + name + " is " + age + " years old and ur gender is: " + w);
            Console.ReadLine();
        }
    }
}
