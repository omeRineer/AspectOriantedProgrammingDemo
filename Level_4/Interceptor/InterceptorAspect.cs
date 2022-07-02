using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_4.Interceptor
{
    public abstract class InterceptorAspect : Attribute, IInterceptor
    {
        public virtual void Intercept(IInvocation invocation)
        {
            Console.WriteLine("Common intercept method is run");
            invocation.Proceed();
        }
    }
}
