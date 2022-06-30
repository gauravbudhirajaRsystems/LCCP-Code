namespace LCCP.Entity
{
    /// <summary>
    /// TestDataEntity class defines properties used for the TestData
    /// </summary>
    public class TestDataEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
    }

    /// <summary>
    /// TestDataEntityList class defines the list used for the TestData
    /// </summary>
    public class TestDataEntityList : List<TestDataEntity>
    {

    }
}