using Castle.DynamicProxy;
using System;

namespace DynamicProxy.Interceptors
{
    public class Interception : Attribute, IInterceptor
    {
        public virtual void Intercept(IInvocation invocation)
        {
            Console.WriteLine("Collaborative working method is run");
        }
    }
}
