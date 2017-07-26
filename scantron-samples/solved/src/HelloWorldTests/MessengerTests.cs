using System;
using Xunit;
using FluentAssertions;
using HelloWorld;

namespace HelloWorldTests
{
    public class MessengerTests
    {
        [Fact]
        public void GetMessage_ReturnsExpectedValue()
        {
            var messenger = new Messenger();
            var message = messenger.GetMessage();
            message.ShouldBeEquivalentTo("Hello World", "the method should return a string literal \"Hello World\"");
        }
    }
}
