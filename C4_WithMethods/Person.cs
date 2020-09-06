using System;
using System.Collections.Generic;
using System.Text;

namespace C4_WithMethods
{
    class Program
    {

        public string Name { get; set; }
        public int Age { get; set; }

        public string City { get; set; }

        public void AskForName()
        {
            Console.Write("Welcome Girl! What's your name? ");
            Name = Console.ReadLine();

            Console.Write($"{Name} sweet :) ");
        }

        public void AskForAge()

        {
            try
            {
                Age = Convert.ToInt32(Console.ReadLine());
            }

            catch
            {
                Console.WriteLine("Sorry girl! Your age must be in digits. Try again.");
                Console.Write(" How old are you girl? ");
                Age = Convert.ToInt32(Console.ReadLine());
            }

            finally
            {
                Console.WriteLine($"Oh cool! We are the sam age. I am also {Age} {Name}. ");
            }
        }


        public void AskForCity()

            Console.Write($"{Name} where do you live")

    }

}
