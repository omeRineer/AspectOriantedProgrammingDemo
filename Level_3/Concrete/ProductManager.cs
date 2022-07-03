using Autofac.Extras.DynamicProxy;
using Level_3.Abstract;
using Level_3.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_3.Concrete
{
    public class ProductManager : IProductService
    {
        [LogAspect]
        [CacheAspect]
        [ValidationAspect]
        public void Add()
        {
            TestDemo();
            Console.WriteLine("Product is added!");
        }

        [LogAspect]
        [CacheAspect]
        [ValidationAspect]
        public virtual void Delete()
        {
            Console.WriteLine("Product is deleted!");
        }

        [LogAspect]
        [CacheAspect]
        [ValidationAspect]
        public virtual void TestDemo()
        {
            Console.WriteLine("TestDemo is run");
        }
    }
}
