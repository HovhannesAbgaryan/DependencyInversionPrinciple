using DemoLibrary.Log;
using DemoLibrary.MessageSender;
using DemoLibrary.Person;

namespace DemoLibrary.Chore
{
    public class Chore : IChore
    {
        #region Fields

        private readonly ILogger logger;
        private readonly IMessageSender messageSender;

        #endregion Fields

        #region Constructor

        public Chore(ILogger logger, IMessageSender messageSender)
        {
            this.logger = logger;
            this.messageSender = messageSender;
        }

        #endregion Constructor

        #region Properties

        /// <summary>
        /// Chore name
        /// </summary>
        public string ChoreName { get; set; }

        /// <summary>
        /// Owner
        /// </summary>
        public IPerson Owner { get; set; }

        /// <summary>
        /// Hours worked
        /// </summary>
        public double HoursWorked { get; private set; }

        /// <summary>
        /// Is complete?
        /// </summary>
        public bool IsComplete { get; private set; }

        #endregion Properties

        #region Functions

        /// <summary>
        /// Performed work
        /// </summary>
        /// <param name="hours">Hours</param>
        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            logger.Log($"Performed work on chore: { ChoreName }");
        }

        /// <summary>
        /// Complete chore
        /// </summary>
        public void CompleteChore()
        {
            IsComplete = true;

            logger.Log($"Completed the chore: { ChoreName }");

            messageSender.SendMessage(Owner, $"The chore { ChoreName } is completed.");
        }

        #endregion Functions
    }
}
