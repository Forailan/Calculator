using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Core.Abstractions
{
    interface ICalculatorManager
    {
        float CalculateExpression(string expression);
    }
}
