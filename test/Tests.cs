using System;
using Xunit;
using StringSumKata;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public void Test1() 
        {            
            var args = new string[] {};
            Program.Main(args);

            Assert.True(true);
        }
    }
}
