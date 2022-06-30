using Level_2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_2.Concrete
{
    public class ProductManager : IProductService
    {
        public virtual void Add()
        {
            Console.WriteLine("Product is added");
        }
    }
}
