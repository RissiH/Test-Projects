using System;

namespace Test_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int age; 

            Console.WriteLine("How old are you?");
            age = int.Parse(Console.ReadLine()); // Get's user input as "age" variable
            Console.WriteLine("You are " + age + " years old");
        }
    }
}
