using Xunit;

namespace Decorator.Tests
{
    public class UpdownBorderTest
    {
        private StringDisplay _stringDisplay;
        private UpdownBorder _updownBorder;

        public UpdownBorderTest()
        {
            _stringDisplay = new StringDisplay("Hello World!");
            _updownBorder = new UpdownBorder(_stringDisplay, '=');
        }

        [Fact]
        public void GetRowTextReturnUpdownBorderString()
        {
            int topPosition = 0;
            Assert.Equal("============", _updownBorder.GetRowText(topPosition));
            Assert.NotEqual("############", _updownBorder.GetRowText(topPosition));

            int dataPosition = 1;
            Assert.Equal("Hello World!", _updownBorder.GetRowText(dataPosition));
            Assert.NotNull(_updownBorder.GetRowText(dataPosition));

            int bottomPosition = _updownBorder.GetRows() - 1;
            Assert.Equal("============", _updownBorder.GetRowText(bottomPosition));
            Assert.NotEqual("############", _updownBorder.GetRowText(bottomPosition));
        }
    }
}
