using Castle.DynamicProxy;
using Level_4.Interceptor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_4.Aspects
{
    public class LogAspect:InterceptorAspect
    {
        public override void Intercept(IInvocation invocation)
        {
            Console.WriteLine("Private LogAspect is run");
            invocation.Proceed();
        }
    }
}
