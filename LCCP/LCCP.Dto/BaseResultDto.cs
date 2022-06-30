namespace LCCP.Dto
{
    /// <summary>
    /// BaseResultDto is a generic data structure that represents each return type of operation
    /// </summary>
    public class BaseResultDto
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}
