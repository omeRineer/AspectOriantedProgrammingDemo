using Castle.DynamicProxy;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProxyDemo.Interceptors
{
    public class LogAspect : Interception
    {
        public override void Intercept(IInvocation invocation)
        {
            System.Console.WriteLine("LogAspect is run");
            invocation.Proceed();
        }
    }
}
