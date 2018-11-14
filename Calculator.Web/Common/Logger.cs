using Calculator.Abstractions;
using System;
using Diagnostics = System.Diagnostics;

namespace Calculator.Web.Common
{
    public class Logger : ILogger
    {
        #region Fields

        private static ILogger logger;

        #endregion

        #region Properties

        public static ILogger Instance
        {
            get
            {
                if (logger == null)
                {
                    logger = new Logger();
                }

                return logger;
            }
        }

        #endregion

        #region Constructors

        private Logger() { }

        #endregion

        #region Methods

        public void Debug(string message)
        {
            Diagnostics.Debug.WriteLine(message);
        }

        public void Error(string message)
        {
            Diagnostics.Debug.WriteLine(message);
        }

        #endregion
    }
}