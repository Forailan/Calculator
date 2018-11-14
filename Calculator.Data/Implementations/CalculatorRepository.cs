using Calculator.Data.Abstractions;
using Calculator.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Data.Implementations
{
    public class CalculatorRepository : ICalculatorRepository
    {
        #region Fields

        private readonly IDbContext dbContext;

        #endregion

        #region Constructors

        public CalculatorRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        #endregion

        public async Task<IEnumerable<Expression>> GetExpressionsAsync()
        {
            await dbContext.RunQueryAsync("SELECT * FROM EXPRESSION");

            return await Task.Run(() => { return new List<Expression>(); });
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            await dbContext.RunQueryAsync("SELECT * FROM USERS");

            return await Task.Run(() => { return new List<User>(); });
        }
    }
}
