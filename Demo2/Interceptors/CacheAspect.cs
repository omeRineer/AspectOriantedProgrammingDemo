using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProxy.Interceptors
{
    public class CacheAspect : Interception
    {
        public override void Intercept(IInvocation invocation)
        {
            Console.WriteLine("CacheAspect is run");
            invocation.Proceed();
        }
    }
}
