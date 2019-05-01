using ProxySample;
using System;
using Xunit;
using Moq;

namespace Proxy.Test
{
    public class UnitTest1
    {
        [Fact]
        public void ConnectTo_ValidSites_CallReal()
        {
            var mock = new Mock<ProxyInternet>();
            string parameter = string.Empty;
            mock.Setup(x => x.ConnectTo(It.IsAny<string>())).Callback<string>(msg => parameter = msg);

            mock.Object.ConnectTo("Hello Sites!!");

            mock.Verify(x => x.ConnectTo(It.IsAny<string>()), Times.Once);
            Assert.Equal("Hello Sites!", parameter);
        }
    }
}
