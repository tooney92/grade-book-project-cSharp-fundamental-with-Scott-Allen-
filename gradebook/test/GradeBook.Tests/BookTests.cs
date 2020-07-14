using System;
using Xunit;
// using GradeBook;


namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {

            //arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            //act
            var result = book.GetStatistics();

            //assert
            Assert.Equal(85.6, result.Average, 1);
          

            
        }

        [Fact]
        public void Test2()
        {

            //arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            //act
            var result = book.GetStatistics();

            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);

            
        }
    }
}
