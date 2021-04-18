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
            book.AddGrade(89.1);
            book.AddGrade(90.1);
            book.AddGrade(77.1);
            book.ShowStatistics();

        }
    }
}
