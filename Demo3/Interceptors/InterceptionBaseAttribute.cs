using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3.Interceptors
{
    public class InterceptionBaseAttribute : Attribute, IInterceptor
    {
        public virtual void OnBefore(IInvocation ınvocation) { }
        public virtual void OnAfter(IInvocation ınvocation) { }
        public virtual void OnException(IInvocation ınvocation) { }
        public virtual void OnSuccess(IInvocation ınvocation) { }
        public void Intercept(IInvocation invocation)
        {
            bool state = true;
            OnBefore(invocation);
            try
            {
                invocation.Proceed();
            }
            catch (Exception)
            {
                state = false;
                OnException(invocation);
            }
            finally
            {
                if (state)
                {
                    OnSuccess(invocation);
                }
            }
            OnAfter(invocation);
        }
    }
}
