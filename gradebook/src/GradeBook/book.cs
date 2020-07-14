using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {

        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade); 
        }

        public void changename(string newName)
        { 
            this.name = newName;
            System.Console.WriteLine("name changed successfully");
        }
        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach (var grade in grades)
            {
                result.Low = Math.Min(grade,  result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }

           result.Average /= grades.Count;  
           return result;
        }
    

        public void allGrades()
        {
            System.Console.WriteLine(string.Join(",", grades));
        }
        public String bookname()
        {
            return this.name;
        }
        

        List<double> grades;
        string name;
    }
}