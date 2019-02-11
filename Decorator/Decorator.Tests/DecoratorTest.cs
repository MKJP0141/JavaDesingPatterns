using System;
using Xunit;

namespace Decorator.Tests
{
    public class DecoratorTests
    {
        public DecoratorTests()
        {
        }

        [Fact]
        public void GetColumnsReturnOne()
        {
            var display = new StringDisplay("Hello World!");
            int oneLine = 1;
            Assert.Equal(oneLine, display.GetRows());

            int twoLine = 2;
            Assert.NotEqual(twoLine, display.GetRows());
        }

        [Fact]
        public void GetRowsTextOneReturnHelloWorld()
        {
            var display = new StringDisplay("Hello World!");
            Assert.Equal("Hello World!", display.GetRowText(0));

            Assert.Null(display.GetRowText(1));
            Assert.Null(display.GetRowText(-1));
        }

        [Fact]
        public void GetColumnsReturn12()
        {
            var display = new StringDisplay("Hello World!");
            Assert.Equal(12, display.GetColumns());
            Assert.NotEqual(11, display.GetColumns());
            Assert.NotEqual(13, display.GetColumns());
        }
    }
}
