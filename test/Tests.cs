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
        [InlineData("9,21", 30)]
        [InlineData("19,37", 56)]
        public void Returns_sum_of_two_numbers_separated_by_comma(string x, int y)
        {
            //Given
            arguments = new string[]{x};
            
            //When
            Program.Main(arguments);   

            //Then
            Assert.Equal(y, int.Parse(consoleOut.ToString()));
        }

        [Theory]
        [InlineData("1,2,9,10,15", 37)]
        public void Returns_sum_of_unknown_amount_of_numbers_separated_by_comma(string x, int y)
        {
            //Given
            arguments = new string[]{x};
            
            //When
            Program.Main(arguments);   

            //Then
            Assert.Equal(y, int.Parse(consoleOut.ToString()));
        }

        [Theory]
        [InlineData("1\n2,3", 6)]
        public void Allow_the_Add_method_to_handle_new_lines_between_numbers(string x, int y)
        {
            //Given
            arguments = new string[]{x};
            
            //When
            Program.Main(arguments);   

            //Then
            Assert.Equal(y, int.Parse(consoleOut.ToString()));
        }

        [Theory]
        [InlineData("//;\n1;2", 3)]
        public void Allow_the_Add_method_with_different_delimiter(string x, int y)
        {
            //Given
            arguments = new string[]{x};
            
            //When
            Program.Main(arguments);   

            //Then
            Assert.Equal(y, int.Parse(consoleOut.ToString()));
        }

        [Fact]
        public void Calling_Add_with_a_negative_number_will_throw_an_exception()
        {
            //Given
            arguments = new string[]{"1,-2,-9,10,-15"};
        
            Exception ex = Assert.Throws<ArgumentException>(() => Program.Main(arguments));
        
            Assert.Equal("negatives not allowed : -2,-9,-15", ex.Message);
        }
    }
}
