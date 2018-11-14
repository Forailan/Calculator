using Calculator.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Data.Abstractions
{
    public interface ICalculatorRepository
    {
        #region Methods

        Task<IEnumerable<Expression>> GetExpressionsAsync();

        Task<IEnumerable<User>> GetUsers();

        #endregion
    }
}
