using System;

namespace DemoLibrary.Log
{
    /// <summary>
    /// Logger
    /// </summary>
    public class Logger : ILogger
    {
        /// <summary>
        /// Log
        /// </summary>
        /// <param name="message">Message</param>
        public void Log(string message)
        {
            Console.WriteLine($"LOG: { message }");
            Console.WriteLine();
        }
    }
}
