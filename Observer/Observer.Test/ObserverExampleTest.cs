using Moq;
using ObserverExample;
using System;
using Xunit;

namespace Observer.Test
{
    public class UnitTest1
    {
        [Fact]
        public void NumberGenerator_Notify_SendAlert()
        {
            var digitMock = new Mock<DigitObserver>();
            digitMock.Setup(x => x.Update(It.IsAny<NumberGenerator>()));

            var graphMock = new Mock<GraphObserver>();
            graphMock.Setup(x => x.Update(It.IsAny<NumberGenerator>()));

            var generator = new RandomNumberGenerator();
            generator.AddObserver(digitMock.Object);
            generator.AddObserver(graphMock.Object);
            generator.NotifyObservers();

            digitMock.Verify(x => x.Update(generator), Times.Once);
            graphMock.Verify(x => x.Update(generator), Times.Once);
        }

        [Fact]
        public void RandomNumberGenerator_Execute_CallNotify20Times()
        {
            var generatorMock = new Mock<RandomNumberGenerator>() { CallBase = true };
            generatorMock.Setup(x => x.NotifyObservers());

            var observer1 = new DigitObserver();
            generatorMock.Object.AddObserver(observer1);
            generatorMock.Object.Execute();

            generatorMock.Verify(x => x.NotifyObservers(), Times.Exactly(20));
        }
    }
}
