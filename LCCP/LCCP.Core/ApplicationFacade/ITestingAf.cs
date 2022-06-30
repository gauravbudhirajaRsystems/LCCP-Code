using LCCP.Dto;

namespace LCCP.Core.ApplicationFacade
{
    /// <summary>
    /// ITestingAf interface defines the method declaration for the CRUD operations on the Test Data
    /// </summary>
    public interface ITestingAf
    {
        // <summary>
        /// Get all the Test Data List 
        /// </summary>
        /// <param></param>
        /// <returns>Returns the TestDataDtoList object</returns>
        public TestDataDtoList GetTestDataList();


        /// <summary>
        /// Get the Test Data Object By Id
        /// </summary>
        /// <param name="id">TestData Id</param>
        /// <returns>Returns the TestDataDto object</returns>
        public TestDataDto GetTestDataById(int id);

        /// <summary>
        /// Add the Test Data Object
        /// </summary>
        /// <param name="testDataDto">TestData object</param>
        /// <returns>Returns the BaseResultDto object</returns>
        public BaseResultDto AddTestData(TestDataDto testDataDto);

        /// <summary>
        /// Update the Test Data Object
        /// </summary>
        /// <param name="testDataDto">TestData object</param>
        /// <returns>Returns the BaseResultDto object</returns>
        public BaseResultDto UpdateTestData(TestDataDto testDataDto);

        /// <summary>
        /// Delete the Test Data Object
        /// </summary>
        /// <param name="id">TestData Id</param>
        /// <returns>Returns the TestDataDto object</returns>
        public BaseResultDto DeleteTestData(int id);
    }
}
