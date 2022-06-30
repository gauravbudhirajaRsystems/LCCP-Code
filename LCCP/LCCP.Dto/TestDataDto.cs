namespace LCCP.Dto
{
    /// <summary>
    /// TestDataDto class defines properties used for the TestData
    /// </summary>
    public class TestDataDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
    }

    /// <summary>
    /// TestDataDtoList class defines the list used for the TestData
    /// </summary>
    public class TestDataDtoList : List<TestDataDto>
    {

    }
}