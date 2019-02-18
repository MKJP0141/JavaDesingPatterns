using Moq;
using Xunit;

namespace Decorator.Tests
{
    public class MultiStringDisplayTest
    {
        private MultiStringDisplay _multiStringDisplay;

        public MultiStringDisplayTest()
        {
            _multiStringDisplay = new MultiStringDisplay();
        }

        [Fact]
        public void ShowReturnsMultiText()
        {
            var mock = new Mock<MultiStringDisplay>();
            mock.Setup((m) => {
                m.Add("おはようございます。";
                m.Add("こんにちは。");
            }).Callback<string>(s =>
            {
                Assert.Equal("おはようございます。\r\nこんにちは。", s);
            });

            /*
            var service = new MultiStringDisplay(mock.Object);
            service.Show();
            mock.Verify(x => service.Show(), "おはようございます。\r\nこんにちは。");


            _multiStringDisplay.Add("おはようございます。");
            _multiStringDisplay.Add("こんにちは。");

        }
    }
}
