using System;

namespace C3_WithAClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            Console.Write("Welcome Girl! What's your name? ");
            person.Name = Console.ReadLine();

            Console.Write($"{person.Name} sweet :) How old are you girl? ");
            // age = Convert.ToInt32(Console.ReadLine());

            try
            {
               person.Age = Convert.ToInt32(Console.ReadLine());

            }

            catch
            {

                Console.WriteLine("Sorry girl! Your age must be in digits. Try again.");
                Console.Write(" How old are you girl? ");
                Person.Age = Convert.ToInt32(Console.ReadLine());
            }

            finally
            {
                Console.WriteLine($"Oh cool! We are the sam age. I am also {age} {name}. ");
            }



           
        }
    }
}
