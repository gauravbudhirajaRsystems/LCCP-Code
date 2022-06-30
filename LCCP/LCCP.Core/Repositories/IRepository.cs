using LCCP.Core.Helper;

namespace LCCP.Core.Repositories
{
    /// <summary>
    /// IRepository interface defines the generic method for the execute query of any type like SQl Text, Stored Procedure and View
    /// </summary>
    public interface IRepository
    {
        /// <summary>
        /// Execute query of any type like SQl Text, Stored Procedure and View
        /// </summary>
        /// <param name="commandText">Command text: SQL Text Command, Stored Procedure Name, View name</param>
        /// <param name="commandType">CommandType: Text, StoredProcedure, View</param>
        /// <param name="parameters">Required Sql Parameters object</param>
        /// <returns>Returns the TEntity List object</returns>
        IEnumerable<TEntity>? ExecuteQuery<TEntity>(string commandText, SqlCommandType commandType, object? parameters = null);

    }
}
