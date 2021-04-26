using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {

        //constructor - has the same name as the class and no return type
        public Book(string name)
        {
            grades = new List<double>();

            Name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            //looping through the array 
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach (double grade in grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);

                result.Average += grade;
            }
            //getting the average grade by dividing result and grades with the with count method
            result.Average /= grades.Count;
            return result;
        }
        private List<double> grades;
        public string Name;


    }
}