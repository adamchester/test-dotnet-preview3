using System;
using Xunit;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public void Test1() 
        {
            
            var slc1 = new Sample.Lib.Class1();
            slc1.ConsoleWriteLineSuccess();
        }
    }
}
