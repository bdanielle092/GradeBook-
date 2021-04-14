using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        //method
        static void Main(string[] args)
        {

            //creating a new array
            var numbers = new[] { 12.7, 18.7, 19.7, 20.4 };
            //list of grades
            var grades = new List<double>() { 12.7, 18.7, 19.7, 20.4 };
            grades.Add(45.5);



            //looping through the array 
            var result = 0.0;
            foreach (double number in grades)
            {
                result += number;
            }
            //getting the average grade by dividing result and grades with the with count method
            result /= grades.Count;
            Console.WriteLine($"The average grade is {result}");
            Console.WriteLine(result);


            if (args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}
