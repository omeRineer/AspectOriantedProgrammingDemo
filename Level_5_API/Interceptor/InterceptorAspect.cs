using Castle.DynamicProxy;
using System;

namespace Level_5_API.Interceptor
{
    public class InterceptorAspect : Attribute, IInterceptor
    {
        public virtual void Intercept(IInvocation invocation)
        {
            
        }
    }
}
