using LCCP.Entity;

namespace LCCP.Core.Repositories
{
    /// <summary>
    /// ITestingRepository interface defines the method declaration for the CRUD operations on the Test Data
    /// </summary>
    public interface ITestingRepository
    {
        /// <summary>
        /// Get all the Test Data List 
        /// </summary>
        /// <param name="query">Stored Procedure Name / Sql Query</param>
        /// <returns>Returns the TestDataEntityList object</returns>
        List<TestDataEntity> GetTestDataList(string query);

        /// <summary>
        /// Get the Test Data Object By Id 
        /// </summary>
        /// <param name="query">Stored Procedure Name / Sql Query</param>
        /// <param name="param">Parameter List of Object/param>
        /// <returns>Returns the TestDataEntity object</returns>
        TestDataEntity GetTestDataById(string query, object param);

        /// <summary>
        /// Add the Test Data Object
        /// </summary>
        /// <param name="query">Stored Procedure Name / Sql Query</param>
        /// <param name="param">Parameter List of Object/param>
        /// <returns>Returns the BaseResultEntity object</returns>
        BaseResultEntity AddTestData(string query, object param);

        /// <summary>
        /// Update the Test Data Object
        /// </summary>
        /// <param name="query">Stored Procedure Name / Sql Query</param>
        /// <param name="param">Parameter List of Object/param>
        /// <returns>Returns the BaseResultEntity object</returns>
        BaseResultEntity UpdateTestData(string query, object param);

        /// <summary>
        /// Delete the Test Data Object
        /// </summary>
        /// <param name="query">Stored Procedure Name / Sql Query</param>
        /// <param name="param">Parameter List of Object/param>
        /// <returns>Returns the BaseResultEntity object</returns>
        BaseResultEntity DeleteTestData(string query, object param);
    }
}
