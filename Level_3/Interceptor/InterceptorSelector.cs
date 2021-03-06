using Castle.DynamicProxy;
using Level_3.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Level_3.Interceptor
{
    public class InterceptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var methodInterceptors = type.GetMethod(method.Name).GetCustomAttributes<InterceptorAspect>(true);
            return methodInterceptors.ToArray();
        }
    }
}
