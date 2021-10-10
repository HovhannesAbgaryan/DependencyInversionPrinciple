using DemoLibrary.Person;

namespace DemoLibrary.Chore
{
    /// <summary>
    /// Chore
    /// </summary>
    public interface IChore
    {
        #region Properties

        /// <summary>
        /// Chore name
        /// </summary>
        string ChoreName { get; set; }

        /// <summary>
        /// Hours worked
        /// </summary>
        double HoursWorked { get; }

        /// <summary>
        /// Is complete?
        /// </summary>
        bool IsComplete { get; }

        /// <summary>
        /// Owner
        /// </summary>
        IPerson Owner { get; set; }

        #endregion Properties

        #region Functions

        /// <summary>
        /// Complete chore
        /// </summary>
        void CompleteChore();

        /// <summary>
        /// Performed work
        /// </summary>
        /// <param name="hours">Hours</param>
        void PerformedWork(double hours);

        #endregion Functions
    }
}