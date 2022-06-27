using Autofac.Extras.DynamicProxy;
using Demo3.Aspects;
using DynamicProxyDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProxyDemo.Concrete
{
    [LogAspect]
    [ValidationAspect]
    public class ProductManager : IProductService
    {
        public virtual void Add()
        {
            Console.WriteLine("Product Added!");
        }
    }
}
