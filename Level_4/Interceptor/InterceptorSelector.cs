using Castle.DynamicProxy;
using Level_4.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Level_4.Interceptor
{
    public class InterceptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var methodInterceptors = type.GetMethod(method.Name).GetCustomAttributes<InterceptorAspect>(true).ToList();
            var classInterceptors = type.GetCustomAttributes<InterceptorAspect>(true).ToList();
            classInterceptors.AddRange(methodInterceptors);

            classInterceptors.AddRange(new List<InterceptorAspect>
            {
                new LogAspect()
            });

            return classInterceptors.ToArray();
        }
    }
}
