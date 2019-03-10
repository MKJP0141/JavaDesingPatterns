using System;
using Xunit;
using Moq;

namespace MediatorRealExample.Test
{
    public class UnitTest1
    {
        [Fact]
        public void PartcipantCtor_Arg1_SetValue()
        {
            var george = new Participant("George");
            Assert.Equal("George", george.Name);
        }

        [Fact]
        public void Chatroom_Register_AddMemberAndRegistChatroom()
        {
            //Given
            var participant = new Participant("George");

            //When
            var chatroom = new Chatroom();
            chatroom.Register(participant);
        
            //Then
            Assert.True(chatroom.ExistParticipant("George"));
            Assert.Same(participant.Chatroom, chatroom);
        }

        [Fact]
        public void Test1()
        {
            /*
            Chartroom chatroom = new Chatroomm();
            Participant George = new Beatle("George");
            var moq = new Moq<Beatle>();
            */
        }
    }
}
