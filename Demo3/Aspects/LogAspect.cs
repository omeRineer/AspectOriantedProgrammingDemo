using Castle.DynamicProxy;
using Demo3.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3.Aspects
{
    public class LogAspect:InterceptionBaseAttribute
    {
        public override void OnBefore(IInvocation ınvocation)
        {
            System.Console.WriteLine("Log is run");
        }
    }
}
