using Dapper;
using LCCP.Core.Repositories;
using LCCP.Entity;
using System.Data;
using System.Data.SqlClient;

namespace LCCP.Repo
{
    /// <summary>
    /// TestingRepository implements the ITestingRepository and Extends the generic behabiour of Repository class and used for the CRUD operations on the Test Data
    /// </summary>
    public class TestingRepository : Repository, ITestingRepository
    {

        #region Constructor

        /// <summary>
        /// TestingRepository Constructor
        /// </summary>
        /// <param name="connection">Database Context</param>
        public TestingRepository(SqlConnection connection) : base(connection)
        {
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Get all the Test Data List 
        /// </summary>
        /// <param name="query">Stored Procedure Name / Sql Query</param>
        /// <returns>Returns the TestDataEntityList object</returns>
        public List<TestDataEntity> GetTestDataList(string query)
        {
            try
            {
                List<TestDataEntity> testDataEntityList = Connection.Query<TestDataEntity>(query, commandType: CommandType.StoredProcedure).ToList();
                return testDataEntityList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Get the Test Data Object By Id 
        /// </summary>
        /// <param name="query">Stored Procedure Name / Sql Query</param>
        /// <param name="param">Parameter List of Object</param>
        /// <returns>Returns the TestDataEntity object</returns>
        public TestDataEntity GetTestDataById(string query, object param)
        {
            try
            {
                TestDataEntity testDataEntity = Connection.Query<TestDataEntity>(query, param, commandType: CommandType.StoredProcedure).First();
                return testDataEntity;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Add the Test Data Object
        /// </summary>
        /// <param name="query">Stored Procedure Name / Sql Query</param>
        /// <param name="param">Parameter List of Object/param>
        /// <returns>Returns the BaseResultEntity object</returns>
        public BaseResultEntity AddTestData(string query, object param)
        {
            try
            {
                BaseResultEntity baseResultEntity = Connection.Query<BaseResultEntity>(query, param, commandType: CommandType.StoredProcedure).First();
                return baseResultEntity;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Update the Test Data Object
        /// </summary>
        /// <param name="query">Stored Procedure Name / Sql Query</param>
        /// <param name="param">Parameter List of Object/param>
        /// <returns>Returns the BaseResultEntity object</returns>
        public BaseResultEntity UpdateTestData(string query, object param)
        {
            try
            {
                BaseResultEntity baseResultEntity = Connection.Query<BaseResultEntity>(query, param, commandType: CommandType.StoredProcedure).First();
                return baseResultEntity;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Delete the Test Data Object
        /// </summary>
        /// <param name="query">Stored Procedure Name / Sql Query</param>
        /// <param name="param">Parameter List of Object/param>
        /// <returns>Returns the BaseResultEntity object</returns>
        public BaseResultEntity DeleteTestData(string query, object param)
        {
            try
            {
                BaseResultEntity baseResultEntity = Connection.Query<BaseResultEntity>(query, param, commandType: CommandType.StoredProcedure).First();
                return baseResultEntity;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}