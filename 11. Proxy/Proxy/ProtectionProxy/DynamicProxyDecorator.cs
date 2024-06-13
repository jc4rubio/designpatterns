namespace Proxy.ProtectionProxy;

using Castle.DynamicProxy;

internal class DynamicProxyDecorator
{
    protected DynamicProxyDecorator() { }

    // ProxyGenerator is used to create DynamicProxy proxy objects
    private static readonly ProxyGenerator _generator = new();

    // CreateClassWithProxy uses inheritance-based proxying to create a new object that actually
    // derives from the provided class and applies interceptors to all APIs before
    // invoking the base class's implementation. In this model, the proxy
    // object and target object are the same.
    public static TTarget DecorateViaInheritance<TTarget, TInterceptor>() 
        where TTarget : class
        where TInterceptor : IInterceptor, new()
    {
        return _generator.CreateClassProxy<TTarget>(new TInterceptor());
    }

    // CreateInterfaceProxyWithTarget uses composition-based proxying to wrap a target object with
    // a proxy object implementing the desired interface. Calls are passed to the target object
    // after running interceptors. This model is similar to DispatchProxy.
    public static TTarget DecorateViaComposition<TTarget, TInterceptor>(TTarget? target = null)
        where TTarget : class
        where TInterceptor : IInterceptor, new()
    {
        target ??= Activator.CreateInstance(typeof(TTarget)) as TTarget;

        return _generator.CreateInterfaceProxyWithTarget(target, new TInterceptor())!;
    }
}