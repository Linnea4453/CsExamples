using System;
using System.Collections.Generic;
using C14_Abstract_1.Models;

namespace C14_Abstract_1
{
    class Program
    {
        static void Main(string[] args)
        {
           


            var classlist = new List<Person>()
            {
            new Teacher { FirstName = "Hans", LastName = "Mattin", Role = "Teacher" },
            new Student { FirstName = "Linnea", LastName = "Nilsson" },
            new Student { FirstName = "Anna", LastName = "Karlsson" },
            new Student { FirstName = "Pelle", LastName = "Persson" },
            };

            foreach (var person in classlist)
            {
                if(person is Teacher teacher)
                Console.WriteLine($"{ teacher.FirstName } {teacher.LastName } - {teacher.Role} ");
                else
                    Console.WriteLine($"{ person.FirstName } { person.LastName } ");

            }

            

        }
    }
}
