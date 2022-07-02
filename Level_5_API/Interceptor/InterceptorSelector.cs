using Castle.DynamicProxy;
using System;
using System.Linq;
using System.Reflection;

namespace Level_5_API.Interceptor
{
    public class InterceptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var methodInterceptor = type.GetMethod(method.Name).GetCustomAttributes<InterceptorAspect>(true).ToList();
            var classInterceptor = type.GetCustomAttributes<InterceptorAspect>(true).ToList();

            classInterceptor.AddRange(methodInterceptor);
            return classInterceptor.ToArray();
        }
    }
}
