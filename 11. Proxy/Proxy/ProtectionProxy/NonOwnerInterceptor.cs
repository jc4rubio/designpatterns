namespace Proxy.ProtectionProxy;

using System.Reflection;
using Castle.DynamicProxy;

internal class NonOwnerInterceptor : IInterceptor
{
    public void Intercept(IInvocation invocation)
    {
        try
        {
            // Invocation.Proceeds goes on to the next interceptor or, if there are no more interceptors, invokes the method.
            // The details of how the method are invoked will depend on the proxying model used. The interceptor does not need
            // to know those details.

            if (invocation.Method.Name.StartsWith("Get"))
            {
                invocation.Proceed();
            }
            else if (invocation.Method.Name.StartsWith("SetGeekRating"))
            {
                invocation.Proceed();
            }
            else if (invocation.Method.Name.StartsWith("Set"))
            {
                throw new UnauthorizedAccessException();
            }
        }
        catch (TargetInvocationException exc)
        {
            Console.WriteLine(exc.StackTrace);
            if (exc.InnerException is null)
            {
                throw;
            }
            throw exc.InnerException;
        }
    }
}
