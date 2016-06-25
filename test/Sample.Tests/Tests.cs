using System;
using Xunit;

namespace Sample.Tests
{
    public class Tests
    {
        [Fact]
        public void SampleLibClass1_ConsoleWriteLineSuccess() 
        {
            var slc1 = new Sample.Lib.Class1();
            slc1.ConsoleWriteLineSuccess();
        }
    }
}
