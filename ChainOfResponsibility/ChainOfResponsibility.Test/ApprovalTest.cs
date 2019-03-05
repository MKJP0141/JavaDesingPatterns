using ChainOfResponsibility.Approver;
using Moq;
using System;
using Xunit;

namespace ChainOfResponsibility.Test
{
    public class ApprovalTest
    {
        [Fact]
        public void GetApprover_UnderTenThousandYen_ReturnsChief()
        {
            var emp = new Mock<IEmployee>();
            emp.Setup(x => x.Title).Returns("Chief");

            /*
            int itemPrice1 = 9999;
            var approver = managementLevel.GetApprover(itemPrice1);
            Assert.Equal("Chief", approverer.Title);

            int itemPrice2 = 10001;
            approver = managementLevel.GetApprover(itemPrice2);
            Assert.NotEqual("Chief", approver.Title);
            */
        }
    }
}
