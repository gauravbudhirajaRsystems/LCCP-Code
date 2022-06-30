using LCCP.Dto;
using LCCP.Entity;

namespace LCCP.Mapping
{
    /// <summary>
    /// BaseResulktMapping class defines methods used for mapping the entity object to dto object
    /// </summary>
    public class BaseResultMapping
    {
        public BaseResultEntity Dto2Entity(BaseResultDto baseResultDto) => new()
        {
            IsSuccess = baseResultDto.IsSuccess,
            Message = baseResultDto.Message,
        };

        public BaseResultDto Entity2Dto(BaseResultEntity baseResultEntity) => new()
        {
            IsSuccess = baseResultEntity.IsSuccess,
            Message = baseResultEntity.Message,
        };
    }
}
