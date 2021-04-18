using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {

        //constructor - has the same name as the class and no return type
        public Book(string name)
        {
            grades = new List<double>();

            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            //looping through the array 
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach (double number in grades)
            {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                result += number;
            }
            //getting the average grade by dividing result and grades with the with count method
            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:N1}");
            Console.WriteLine($"This is the highest grade {highGrade}");
            Console.WriteLine($"This is the lowest grade {lowGrade}");

        }
        private List<double> grades;
        private string name;


    }
}