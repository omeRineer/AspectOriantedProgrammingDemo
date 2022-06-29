using Autofac.Extras.DynamicProxy;
using Level_1.Abstract;
using Level_1.Interceptor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_1.Concrete
{
    [Intercept(typeof(CacheInterceptor))]
    [Intercept(typeof(ValidationInterceptor))]
    public class ProductManager : IProductService
    {
        public virtual void Add()
        {
            Console.WriteLine("Product is added!");
        }
    }
}
