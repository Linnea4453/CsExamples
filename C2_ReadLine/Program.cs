using System;

namespace C2_ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age = 0;


            Console.Write("Welcome Girl! What's your name? ");
            name = Console.ReadLine();

            Console.Write($"{name} sweet :) How old are you girl? ");
            // age = Convert.ToInt32(Console.ReadLine());

            try
            {
                age = Convert.ToInt32(Console.ReadLine());

            }

            catch
            {

                Console.WriteLine("Sorry girl! Your age must be in digits. Try again.");
                Console.Write(" How old are you girl? ");
                age = Convert.ToInt32(Console.ReadLine());
            }

            finally
            {
                Console.WriteLine($"Oh cool! We are the sam age. I am also {age} {name}. ");
            }



                Console.WriteLine($"Oh cool! We are the sam age. I am also {age}. ");

            Console.Write($"Girl yor name contains {name.Length} characters.");
            Console.WriteLine($"{name} Where do you live?");
            string city;     Console.ReadLine();
        






        }
    }
}
