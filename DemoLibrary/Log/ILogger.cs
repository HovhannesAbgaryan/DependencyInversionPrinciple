namespace DemoLibrary.Log
{
    /// <summary>
    /// Logger
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Log
        /// </summary>
        /// <param name="message">Message</param>
        void Log(string message);
    }
}