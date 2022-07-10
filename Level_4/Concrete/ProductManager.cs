using Autofac.Extras.DynamicProxy;
using Level_4.Abstract;
using Level_4.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_4.Concrete
{
    public class ProductManager : IProductService
    {
        [CacheAspect]
        [ValidationAspect]
        public void Add()
        {
            Console.WriteLine("Product is added!");
        }

        [CacheAspect]
        [ValidationAspect]
        public virtual void Delete()
        {
            Console.WriteLine("Product is deleted!");
        }
    }
}
