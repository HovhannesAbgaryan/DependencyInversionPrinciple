using DemoLibrary.Person;

namespace DemoLibrary.MessageSender
{
    /// <summary>
    /// Message sender
    /// </summary>
    public interface IMessageSender
    {
        /// <summary>
        /// Send message
        /// </summary>
        /// <param name="person">Person</param>
        /// <param name="message">Message</param>
        void SendMessage(IPerson person, string message);
    }
}