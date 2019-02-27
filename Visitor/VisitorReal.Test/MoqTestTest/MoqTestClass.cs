using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using MoqTest.Model;
using Xunit;

namespace VisitorReal.Test.MoqTestTest
{
    public class MoqTestClass
    {
        [Fact]
        public void GetFullNameTest()
        {
            var fullName = "山田 太郎";
            var mock = new Mock<IEmployee>();
            mock.Setup(x => x.GetFullName())
                .Returns(() => fullName);

            Assert.Equal(fullName, mock.Object.GetFullName());
        }

        [Fact]
        public void ToCSVTest()
        {
            var mock = new Mock<IEmployee>();
            var csv = string.Empty;
            mock.Setup(x => x.ToCSV(It.IsAny<string>(), It.IsAny<string>()))
                .Callback<string, string>((l, f) => csv = $"{l},{f}");
                                

            mock.Object.ToCSV("山田", "太郎");
            Assert.Equal("山田,太郎", csv);
            mock.Verify();
        }
    }
}
