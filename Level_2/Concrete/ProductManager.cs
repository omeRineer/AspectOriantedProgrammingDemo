using Autofac.Extras.DynamicProxy;
using Level_2.Abstract;
using Level_2.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_2.Concrete
{
    [Intercept(typeof(ValidationAspect))]
    public class ProductManager : IProductService
    {
        public virtual void Add()
        {
            Console.WriteLine("Product is added");
        }
    }
}
