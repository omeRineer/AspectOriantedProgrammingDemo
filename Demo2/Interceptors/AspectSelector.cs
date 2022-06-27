using Castle.DynamicProxy;
using DynamicProxyDemo.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Demo2.Interceptors
{
    public class AspectSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var attributes = type.GetCustomAttributes<Interception>(true).ToList();
            return attributes.ToArray();
        }
    }
}
