namespace LCCP.Entity
{
    /// <summary>
    /// BaseResultEntity is a generic data structure that represents each return type of operation
    /// </summary>
    public class BaseResultEntity
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}
