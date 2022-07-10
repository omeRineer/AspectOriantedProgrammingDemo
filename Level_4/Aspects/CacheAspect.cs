using Castle.DynamicProxy;
using Level_4.Interceptor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_4.Aspects
{
    public class CacheAspect : InterceptorAspect
    {
        protected override void OnAfter(IInvocation invocation)
        {
            Console.WriteLine($"{invocation.Method.Name} metodu cachee eklendi");
        }
    }
}
