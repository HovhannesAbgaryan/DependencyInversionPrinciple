using DemoLibrary.Person;
using System;

namespace DemoLibrary.MessageSender
{
    /// <summary>
    /// Texter
    /// </summary>
    public class Texter : IMessageSender
    {
        /// <summary>
        /// Send message
        /// </summary>
        /// <param name="person">Person</param>
        /// <param name="message">Message</param>
        public void SendMessage(IPerson person, string message)
        {
            Console.WriteLine($"Text message to: { person.FirstName }. Message: { message }");
            Console.WriteLine();
        }
    }
}
