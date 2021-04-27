using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        //method
        static void Main(string[] args)
        {


            //instantiaiting the book which mean creating a new object using the new keyword
            var book = new Book("Faith's Grade Book ");


            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);

                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }
            }


            var stats = book.GetStatistics();
            Console.WriteLine($"This is the lowest grade {stats.Low}");
            Console.WriteLine($"This is the highest grade {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The letter grade is {stats.Letter}");


        }
    }
}
