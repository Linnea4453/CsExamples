using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace C5_WithAgeCalculation
{
    class Person
    {

        public string Name { get; set; }
        public int Age { get; set; }

        public string City { get; set; }



        public DateTime DateOfBirth { get; set; }


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

        public void AskForDateOfBirth()

        {
            Console.Write("When were you born?");
            try
            {
                DateOfBirth = Convert.ToDateTime(Console.ReadLine());
            }
            catch
            {
                Console.Write("Sorry girl, I mean when, like 1999-01-01. So when were you born?");
            }
            try
            {
                DateOfBirth = Convert.ToDateTime(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("You are so stupid!");
            }

        }

        private int CalculateAge();
        {
        Age = DateTime.Now.Year - DateOfBirth.Year;
            if(DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)
            Age = 

          
}

    }
}
