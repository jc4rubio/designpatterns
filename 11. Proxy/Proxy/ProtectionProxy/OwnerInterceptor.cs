namespace Proxy.ProtectionProxy;

using System.Reflection;
using Castle.DynamicProxy;

internal class OwnerInterceptor : IInterceptor
{
    // The Intercept method is where the interceptor decides how to handle calls to the proxy object
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
                throw new UnauthorizedAccessException();
            }
            else if (invocation.Method.Name.StartsWith("Set"))
            {
                invocation.Proceed();
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
