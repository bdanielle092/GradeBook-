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
            var book = new DiskBook("Faith's Grade Book ");
            book.GradeAdded += OnGradAdded;

            EnterGrades(book);

            var stats = book.GetStatistics();

            Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($"This is the lowest grade {stats.Low}");
            Console.WriteLine($"This is the highest grade {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The letter grade is {stats.Letter}");


        }

        private static void EnterGrades(IBook book)
        {

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
        }

        static void OnGradAdded(object sender, EventArgs e)
        {
            Console.WriteLine("A grade was Added");
        }
    }
}
