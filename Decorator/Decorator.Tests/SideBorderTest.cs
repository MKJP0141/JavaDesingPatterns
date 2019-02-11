using Xunit;

namespace Decorator.Tests
{
    public class SideBorderTest
    {
        private StringDisplay _stringDisplay;
        private SideBorder _sideBorder;

        public SideBorderTest()
        {
            _stringDisplay = new StringDisplay("Hello World!");
            _sideBorder = new SideBorder(_stringDisplay, '|');
        }

        [Fact]
        public void GetColumnReturns14()
        {
            Assert.Equal(14, _sideBorder.GetColumns());
            Assert.NotEqual(13, _sideBorder.GetColumns());
        }

        [Fact]
        public void GetRowRerutn1()
        {
            Assert.Equal(1, _sideBorder.GetRows());
            Assert.NotEqual(0, _sideBorder.GetRows());
        }

        [Fact]
        public void GetRowTextReturnHelloWorldWithSideBorder()
        {
            int rowPosition = 0;
            Assert.Equal("|Hello World!|", _sideBorder.GetRowText(rowPosition));
            Assert.NotEqual("#Hello World!#", _sideBorder.GetRowText(rowPosition));

            int nextRowPosition = 1;
            Assert.NotNull(_sideBorder.GetRowText(nextRowPosition));
            Assert.Equal("||", _sideBorder.GetRowText(nextRowPosition));
        }
    }
}