using Xunit;

namespace Decorator.Tests
{
    public class FullBorderTest
    {
        private StringDisplay _stringDisplay;
        private FullBorder _fullBorder;

        public FullBorderTest()
        {
            _stringDisplay = new StringDisplay("Hello World!");
            _fullBorder = new FullBorder(_stringDisplay);
        }

        [Fact]
        public void GetColumnReturn14()
        {
            Assert.Equal(14, _fullBorder.GetColumns());
            Assert.NotEqual(13, _fullBorder.GetColumns());
        }

        [Fact]
        public void GetRowReturn3()
        {
            Assert.Equal(3, _fullBorder.GetRows());
            Assert.NotEqual(2, _fullBorder.GetRows());
        }

        [Fact]
        public void GetRowTextReturnBorderHelloWorld()
        {
            Assert.Equal("+------------+", _fullBorder.GetRowText(0));
            Assert.Equal("+------------+", _fullBorder.GetRowText(_fullBorder.GetRows() - 1));
            Assert.Equal("|Hello World!|", _fullBorder.GetRowText(1));
        }
    }
}