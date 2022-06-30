using LCCP.Core.DomainServices;
using LCCP.Core.Repositories;
using LCCP.Entity;

namespace LCCP.Services
{
    /// <summary>
    /// TestingService class implements the ITestingService and used for the CRUD operations on the Test Data
    /// </summary>
    public class TestingService : ITestingService
    {
        #region Private Memebers

        private readonly ITestingRepository _testingRepository;

        #endregion

        #region Constructor

        public TestingService(ITestingRepository testingRepository)
        {
            _testingRepository = testingRepository;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Get all the Test Data List 
        /// </summary>
        /// <param></param>
        /// <returns>Returns the TestDataEntity List object</returns>
        public List<TestDataEntity> GetTestDataList()
        {
            return _testingRepository.GetTestDataList(query: "usp_GetTestData");
        }

        /// <summary>
        /// Get the Test Data Object By Id 
        /// </summary>
        /// <param name="id">TestData Id</param>
        /// <returns>Returns the TestDataEntity object</returns>
        public TestDataEntity GetTestDataById(int id)
        {
            return _testingRepository.GetTestDataById(query: "usp_GetTestDataById", param: new { Id = id });
        }

        /// <summary>
        /// Add the Test Data Object
        /// </summary>
        /// <param name="testDataEntity">TestData Object</param>
        /// <returns>Returns the BaseResultEntity object</returns>
        public BaseResultEntity AddTestData(TestDataEntity testDataEntity)
        {
            return _testingRepository.AddTestData(query: "usp_AddTestData", param: new { testDataEntity.Name, testDataEntity.EmailAddress });
        }

        /// <summary>
        /// Update the Test Data Object
        /// </summary>
        /// <param name="testDataEntity">TestData Object</param>
        /// <returns>Returns the BaseResultEntity object</returns>
        public BaseResultEntity UpdateTestData(TestDataEntity testDataEntity)
        {
            return _testingRepository.UpdateTestData(query: "usp_UpdateTestData", param: new { testDataEntity.Id, testDataEntity.Name, testDataEntity.EmailAddress });
        }

        /// <summary>
        /// Update the Test Data Object
        /// </summary>
        /// <param name="testDataEntity">TestData Object</param>
        /// <returns>Returns the BaseResultEntity object</returns>
        public BaseResultEntity DeleteTestData(int id)
        {
            return _testingRepository.DeleteTestData(query: "usp_DeleteTestData", param: new { Id = id });
        }



        #endregion
    }
}