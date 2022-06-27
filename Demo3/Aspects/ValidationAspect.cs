using Castle.DynamicProxy;
using Demo3.Interceptors;

namespace Demo3.Aspects
{
    public class ValidationAspect:InterceptionBaseAttribute
    {
        public override void OnAfter(IInvocation ınvocation)
        {
            System.Console.WriteLine("Validation is run");
        }
    }
}
