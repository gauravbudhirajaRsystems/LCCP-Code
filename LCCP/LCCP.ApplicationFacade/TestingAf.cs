using LCCP.Core.ApplicationFacade;
using LCCP.Core.DomainServices;
using LCCP.Dto;
using LCCP.Entity;
using LCCP.Mapping;

namespace LCCP.ApplicationFacade
{
    public class TestingAf : ITestingAf
    {
        #region Private Memebers

        private readonly ITestingService _testingService;
        private readonly TestDataMapping _testingMapping;
        private readonly BaseResultMapping _baseResultMapping;

        #endregion

        #region Constructor

        public TestingAf(ITestingService testingService)
        {
            _testingService = testingService;
            _testingMapping = new TestDataMapping();
            _baseResultMapping = new BaseResultMapping();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Get all the Test Data List 
        /// </summary>
        /// <param></param>
        /// <returns>Returns the TestDataDtoList object</returns>
        public TestDataDtoList GetTestDataList()
        {
            List<TestDataEntity> testDataEntityList = _testingService.GetTestDataList();

            TestDataDtoList testDtoList = _testingMapping.ListOfTestDataEntity2DtoList(testDataEntityList);

            return testDtoList;
        }

        /// <summary>
        /// Get the Test Data Object By Id 
        /// </summary>
        /// <param name="id">TestData Id</param>
        /// <returns>Returns the TestDataDto object</returns>
        public TestDataDto GetTestDataById(int id)
        {
            TestDataEntity testDataEntity = _testingService.GetTestDataById(id);

            TestDataDto testDataDto = _testingMapping.TestDataEntity2Dto(testDataEntity);

            return testDataDto;
        }

        /// <summary>
        /// Add the Test Data Object
        /// </summary>
        /// <param name="testDataDto">TestData Object</param>
        /// <returns>Returns the BaseResultDto object</returns>
        public BaseResultDto AddTestData(TestDataDto testDataDto)
        {
            TestDataEntity testDataEntity = _testingMapping.TestDataDto2Entity(testDataDto);

            BaseResultEntity baseResultEntity = _testingService.AddTestData(testDataEntity);

            BaseResultDto baseResultDto = _baseResultMapping.Entity2Dto(baseResultEntity);

            return baseResultDto;
        }

        /// <summary>
        /// Update the Test Data Object
        /// </summary>
        /// <param name="testDataDto">TestData Object</param>
        /// <returns>Returns the BaseResultDto object</returns>
        public BaseResultDto UpdateTestData(TestDataDto testDataDto)
        {
            TestDataEntity testDataEntity = _testingMapping.TestDataDto2Entity(testDataDto);

            BaseResultEntity baseResultEntity = _testingService.UpdateTestData(testDataEntity);

            BaseResultDto baseResultDto = _baseResultMapping.Entity2Dto(baseResultEntity);

            return baseResultDto;
        }

        /// <summary>
        /// Delete the Test Data Object
        /// </summary>
        /// <param name="id">TestData Id</param>
        /// <returns>Returns the TestDataDto object</returns>
        public BaseResultDto DeleteTestData(int id)
        {
            BaseResultEntity baseResultEntity = _testingService.DeleteTestData(id);

            BaseResultDto baseResultDto = _baseResultMapping.Entity2Dto(baseResultEntity);

            return baseResultDto;
        }

        #endregion
    }
}