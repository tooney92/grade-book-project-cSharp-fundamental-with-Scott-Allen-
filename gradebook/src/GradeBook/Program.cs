using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("science class");
            book.AddGrade(89.1);
            book.AddGrade(19.1);
            book.AddGrade(29.1);
            // System.Console.WriteLine(book.bookname()); 
            book.allGrades();
            
            var stats = book.GetStatistics();
           
            System.Console.WriteLine(stats.Average);
            
            
           
        }
    }
}
