using DemoLibrary.Chore;
using DemoLibrary.Log;
using DemoLibrary.MessageSender;
using DemoLibrary.Person;

namespace ConsoleUI
{
    /// <summary>
    /// Factory
    /// </summary>
    public static class Factory
    {
        #region Person

        /// <summary>
        /// Create person
        /// </summary>
        /// <returns>Person</returns>
        public static IPerson CreatePerson()
        {
            return new Person();
        }

        #endregion Person

        #region Chore

        /// <summary>
        /// Create chore
        /// </summary>
        /// <returns>Chore</returns>
        public static IChore CreateChore()
        {
            return new Chore(CreateLogger(), CreateMessageSender());
        }

        #endregion Chore

        #region Logger

        /// <summary>
        /// Create logger
        /// </summary>
        /// <returns>Logger</returns>
        public static ILogger CreateLogger()
        {
            return new Logger();
        }

        #endregion Logger

        #region Message sender

        /// <summary>
        /// Create message sender
        /// </summary>
        /// <returns>Message sender</returns>
        public static IMessageSender CreateMessageSender()
        {
            //Variant N1
            return new Emailer();

            //Variant N2
            //return new Texter();
        }

        #endregion Message sender
    }
}
