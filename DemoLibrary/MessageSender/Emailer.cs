using DemoLibrary.Person;
using System;

namespace DemoLibrary.MessageSender
{
    /// <summary>
    /// Emailer
    /// </summary>
    public class Emailer : IMessageSender
    {
        /// <summary>
        /// Send message
        /// </summary>
        /// <param name="person">Person</param>
        /// <param name="message">Message</param>
        public void SendMessage(IPerson person, string message)
        {
            Console.WriteLine($"Simulating sending an email to { person.EmailAddress }");
            Console.WriteLine();
        }
    }
}
