using Moq;
using System;
using Xunit;

namespace MediatorRealExample.Tests
{
    public class MediatorRealExampleTest
    {
        private Participant _george;
        private string _georgeName = "George";

        public MediatorRealExampleTest()
        {
            _george = new Beatle(_georgeName);
        }

        [Fact]
        public void PartcipantCtor_Arg1_SetValue()
        {
            var george = new Beatle(_georgeName);
            Assert.Equal(_georgeName, george.Name);
        }

        [Fact]
        public void Chatroom_Register_AddMemberAndRegistChatroom()
        {
            //Given

            //When
            var chatroom = new Chatroom();
            chatroom.Register(_george);

            //Then
            Assert.True(chatroom.ExistParticipant(_georgeName));
            Assert.Same(chatroom, _george.Chatroom);
        }

        [Fact]
        public void Chatroom_Send_CallParticipantReceive()
        {
            Chatroom chatroom = new Chatroom();

            var georgeMock = new Mock<Participant>(_georgeName);
            georgeMock.Setup(x => x.Send(It.IsAny<string>(), It.IsAny<string>())).Callback(() => Console.WriteLine("Hello"));
            georgeMock.Setup(x => x.Name).Returns(_georgeName);

            var yokoMock = new Mock<Participant>("Yoko");
            yokoMock.Setup(x => x.Name).Returns("Yoko");
            yokoMock.Setup(x => x.Receive(It.IsAny<string>(), It.IsAny<string>()));

            chatroom.Register(georgeMock.Object);
            chatroom.Register(yokoMock.Object);

            chatroom.Send(_georgeName, "Yoko", "Hello Yoko");

            yokoMock.Verify(x => x.Receive("George", "Hello Yoko"), Times.Once);
        }

        [Fact]
        public void Participant_Send_CallChatroomSend()
        {
            var mock = new Mock<Chatroom>();
            mock.Setup(x => x.Register(It.IsAny<Participant>())).Callback(() => _george.Chatroom = mock.Object);
            mock.Setup(x => x.Send(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()));

            mock.Object.Register(_george);
            _george.Send("Yoko", "Hello Yoko");

            mock.Verify(x => x.Send(_georgeName, "Yoko", "Hello Yoko"), Times.Once);
        }
    }
}
