using System.Threading.Tasks;

namespace Calculator.Data.Abstractions
{
    public interface IDbContext
    {
        #region Methods

        Task RunQueryAsync(string queryString);

        #endregion
    }
}
