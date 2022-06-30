using Dapper;
using LCCP.Core.Helper;
using LCCP.Core.Repositories;
using System.Data;
using System.Data.SqlClient;

namespace LCCP.Repo
{
    /// <summary>
    /// Repository class implements the IRepository and used to implement generic method for the execute query of any type like SQl Text, Stored Procedure and View
    /// </summary>
    public class Repository : IRepository
    {
        #region Protected Memebers

        protected SqlConnection Connection;

        #endregion

        #region Constructor

        public Repository(SqlConnection connection)
        {
            Connection = connection;
        }

        #endregion

        #region Public Methods

        public IEnumerable<TEntity>? ExecuteQuery<TEntity>(string commandText, SqlCommandType commandType, object? parameters = null)
        {
            try
            {
                switch (commandType)
                {
                    case SqlCommandType.StoredProcedure:
                        return Connection.Query<TEntity>(commandText, parameters, commandType: CommandType.StoredProcedure);

                    case SqlCommandType.Text:
                        return Connection.Query<TEntity>(commandText, parameters, commandType: CommandType.StoredProcedure);

                    case SqlCommandType.View:
                        return Connection.Query<TEntity>(commandText, parameters, commandType: CommandType.StoredProcedure);

                    default: return default;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion
    }
}
