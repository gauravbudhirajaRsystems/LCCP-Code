using LCCP.Dto;
using LCCP.Entity;

namespace LCCP.Mapping
{
    /// <summary>
    /// TestDataMapping class defines methods used for mapping the entity object to dto object
    /// </summary>
    public class TestDataMapping
    {
        /// <summary>
        /// Map the ListOfTestDataEntity object to TestDataDtoList object
        /// </summary>
        /// <param name="testEntityList"></param>
        /// <returns>TestDtoList</returns>
        public TestDataDtoList ListOfTestDataEntity2DtoList(List<TestDataEntity> testEntityList)
        {
            TestDataDtoList testDtoList = new();

            testEntityList.ForEach(testEntity =>
            {
                testDtoList.Add(item: TestDataEntity2Dto(testEntity));
            });

            return testDtoList;
        }

        /// <summary>
        /// Map the TestDataEntity Object to TestDataDto object
        /// </summary>
        /// <param name="testEntity"></param>
        /// <returns>TestDataDto</returns>
        public TestDataDto TestDataEntity2Dto(TestDataEntity testEntity) => new()
        {
            Id = testEntity.Id,
            Name = testEntity.Name,
            EmailAddress = testEntity.EmailAddress,
        };

        /// <summary>
        /// Map the TestDataDto Object to TestDataEntity object
        /// </summary>
        /// <param name="testEntity"></param>
        public TestDataEntity TestDataDto2Entity(TestDataDto testDataDto) => new()
        {
            EmailAddress = testDataDto.EmailAddress,
            Id = testDataDto.Id,
            Name = testDataDto.Name
        };


        #region Private Methods



        #endregion

    }
}