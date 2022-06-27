using Autofac.Extras.DynamicProxy;
using DynamicProxy.Abstract;
using DynamicProxy.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProxy.Concrete
{
    [Intercept(typeof(CacheAspect))]
    [Intercept(typeof(LogAspect))]
    public class ProductManager : IProductService
    {
        public virtual void Add()
        {
            Console.WriteLine("Product Added!");
        }
    }
}
