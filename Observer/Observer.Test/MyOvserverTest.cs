using Moq;
using MyObserver;
using ObserverExample;
using Xunit;

namespace Observer.Test
{
    public class MyObserverTest
    {
        [Fact]
        public void PostOffice_Notify_CallSubscribersUpdate()
        {
            IPostOffice postOffice = new PostOffice();
            IPostOffice postValue = null;
            var yokoMock = new Mock<Subscriber>("Yoko");
            yokoMock.Setup(x => x.Update(It.IsAny<IPostOffice>())).Callback<IPostOffice>(office => postValue = office);
            postOffice.AttachSubscriber(yokoMock.Object);

            ILetter letter = new Letter(from:"John", to:"Yoko");
            postOffice.Receive(letter);
            yokoMock.Verify(x => x.Update(postOffice), Times.Once);
            Assert.Same(postValue, postOffice);
        }

        /*
        [Fact]
        public void NumberGenerator_Notify_SendAlert()
        {
            var digitMock = new Mock<DigitObserver>();
            NumberGenerator argInstance = null;
            digitMock.Setup(x => x.Update(It.IsAny<NumberGenerator>())).Callback<NumberGenerator>(sm => argInstance = sm);

            var graphMock = new Mock<GraphObserver>();
            graphMock.Setup(x => x.Update(It.IsAny<NumberGenerator>()));

            var generator = new RandomNumberGenerator();
            generator.AddObserver(digitMock.Object);
            generator.AddObserver(graphMock.Object);
            generator.NotifyObservers();

            digitMock.Verify(x => x.Update(generator), Times.Once);
            Assert.Same(argInstance, generator);
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

        [Fact]
        public void PaddingObserver_Update_Pad5Text()
        {
            var mock = new Mock<IncrementalNumberGenerator>(5, 10, 5);
            mock.SetupSequence(x => x.GetNumber())
                .Returns(5)
                .Returns(10)
                .Returns(15);

            var observer = new PaddingObserver("C#");
            observer.Update(mock.Object);
            observer.Update(mock.Object);
            observer.Update(mock.Object);

            mock.Verify(x => x.GetNumber(), Times.Exactly(3));
        }
        */
    }
}
