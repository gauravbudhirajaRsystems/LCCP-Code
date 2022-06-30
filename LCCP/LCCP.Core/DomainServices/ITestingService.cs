using LCCP.Entity;

namespace LCCP.Core.DomainServices
{
    /// <summary>
    /// ITestingService interface defines the method declaration for the CRUD operations on the Test Data
    /// </summary>
    public interface ITestingService
    {
        // <summary>
        /// Get all the Test List 
        /// </summary>
        /// <param></param>
        /// <returns>Returns the TestDataEntityList object</returns>
        public List<TestDataEntity> GetTestDataList();

        /// <summary>
        /// Get the Test Data Object By Id 
        /// </summary>
        /// <param name="id">TestData Id</param>
        /// <returns>Returns the TestDataEntity object</returns>
        public TestDataEntity GetTestDataById(int id);

        /// <summary>
        /// Add the Test Data Object
        /// </summary>
        /// <param name="testDataEntity">TestData Object</param>
        /// <returns>Returns the BaseResultEntity object</returns>
        BaseResultEntity AddTestData(TestDataEntity testDataEntity);

        /// <summary>
        /// Update the Test Data Object
        /// </summary>
        /// <param name="testDataEntity">TestData Object</param>
        /// <returns>Returns the BaseResultEntity object</returns>
        BaseResultEntity UpdateTestData(TestDataEntity testDataEntity);

        /// <summary>
        /// Get the Test Data Object
        /// </summary>
        /// <param name="id">TestData Id</param>
        /// <returns>Returns the BaseResultEntity object</returns>
        public BaseResultEntity DeleteTestData(int id);
    }
}
