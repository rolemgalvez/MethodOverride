using HomeworkTwentySix.Library;
using System;

namespace HomeworkTwentySix.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel
            {
                FirstName = "Juan",
                LastName = "Cruz"
            };

            Console.WriteLine(person);

            Console.ReadLine();
        }
    }
}
