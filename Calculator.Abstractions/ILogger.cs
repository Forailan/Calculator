using System;

namespace Calculator.Abstractions
{
    public interface ILogger
    {
        void Debug(string message);

        void Error(string message);
    }
}
