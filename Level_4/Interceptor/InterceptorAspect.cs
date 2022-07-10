using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_4.Interceptor
{
    public abstract class InterceptorAspect : Attribute, IInterceptor
    {
        protected virtual void OnBefore(IInvocation invocation) { }
        protected virtual void OnAfter(IInvocation invocation) { }
        protected virtual void OnException(IInvocation invocation, Exception e) { }
        protected virtual void OnSuccess(IInvocation invocation) { }
        public virtual void Intercept(IInvocation invocation)
        {
            bool state = true;
            OnBefore(invocation);
            try
            {
                invocation.Proceed();
            }
            catch (Exception e)
            {
                state = false;
                OnException(invocation, e);

                throw;
            }
            finally
            {
                if (state)
                    OnSuccess(invocation);
            }
            OnAfter(invocation);
        }
    }
}
