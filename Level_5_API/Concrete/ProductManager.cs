using Level_5_API.Abstract;
using Level_5_API.Aspects;
using Level_5_API.Models;

namespace Level_5_API.Concrete
{
    public class ProductManager : IProductService
    {
        [CacheAspect]
        public ResultModel Add()
        {
            return new ResultModel
            {
                State=true,
                Message="Product is added"
            };
        }

        public ResultModel Delete()
        {
            return new ResultModel
            {
                State = true,
                Message = "Product is deleted"
            };
        }
    }
}
