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
        protected override void OnBefore(IInvocation invocation)
        {
            Console.WriteLine($"Log Kaydı : {invocation.Method.Name} metodu çalıştı");
        }

        protected override void OnException(IInvocation invocation, Exception e)
        {
            Console.WriteLine($"Log Kaydı : {invocation.Method.Name} metodu hata verdi");
        }

        protected override void OnSuccess(IInvocation invocation)
        {
            Console.WriteLine($"Log Kaydı : {invocation.Method.Name} metodu başarıyla çalıştı");
        }

        protected override void OnAfter(IInvocation invocation)
        {
            Console.WriteLine($"Log Kaydı : {invocation.Method.Name} metodu sona erdi");
        }
    }
}
