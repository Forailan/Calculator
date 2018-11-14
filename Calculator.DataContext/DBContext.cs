using Calculator.Abstractions;
using Calculator.Data.Abstractions;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Calculator.Data
{
    public class DBContext : IDbContext
    {
        #region Fields

        private readonly string connectionString;
        private readonly ILogger logger;

        #endregion

        #region Properties

        private SqlConnection Connection => new SqlConnection(connectionString);

        #endregion

        #region Constructors

        public DBContext(string connectionString, ILogger logger)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentNullException(nameof(connectionString));
            }

            this.connectionString = connectionString;
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        #endregion

        #region Methods

        public Task RunQueryAsync(string queryString)
        {
            return Task.Run(() =>
            {
                SqlCommand sqlCommand = null;

                try
                {
                    sqlCommand = new SqlCommand(queryString, this.Connection)
                    {
                        CommandType = CommandType.Text

                    };

                    var adapter = new SqlDataAdapter(sqlCommand);
                    var dataSet = new DataSet();
                    adapter.Fill(dataSet);

                }
                catch (Exception ex)
                {

                }
                finally
                {
                    try
                    {
                        if (sqlCommand != null)
                        {
                            sqlCommand.Dispose();
                        }
                    }
                    catch { }
                }
            });
        }

        #endregion           
    }
}
