using System;
using Xunit;
using StringSumKata;
using System.IO;

namespace Tests
{
    public class Tests : IDisposable
    {

        private StringWriter consoleOut;
        private string[] arguments;

        public Tests()
        {
            consoleOut = new StringWriter();
            Console.SetOut(consoleOut);

            
        }

        public void Dispose()
        {
            
        }

        [Fact]    
        public void Retuns_0_if_empty_arguments() 
        {  
            // Arrange 
            arguments = new string[]{};
            // Act 
            Program.Main(arguments);
            
            // Assert 
            Assert.Equal(0, int.Parse(consoleOut.ToString()));
        }

        [Theory]
        [InlineData("1", 1)]
        [InlineData("2", 2)]
        [InlineData("33", 33)]
        [InlineData("102", 102)]
        public void Returns_int_value_of_string_when_one_argument(string x, int y)
        {
            //Given
            arguments = new string[]{x};
            
            //When
            Program.Main(arguments);   

            //Then
            Assert.Equal(y, int.Parse(consoleOut.ToString()));
        }

        [Theory]
        [InlineData("1,2", 3)]
        public void Returns_sum_of_two_numbers_separated_by_comma(string x, int y)
        {
            //Given
            arguments = new string[]{x};
            
            //When
            Program.Main(arguments);   

            //Then
            Assert.Equal(y, int.Parse(consoleOut.ToString()));
        }
    }
}
