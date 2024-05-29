namespace TemplateMethod.OthersExamples;

internal abstract class AbstractClass
{
    protected void TemplateMethod()
    {
        this.PrimitiveOperation1();
        this.PrimitiveOperation2();
        this.ConcreteOperation();
        this.Hook();
    }

    protected abstract void PrimitiveOperation1(); // Implementated by concrete subclasses

    protected abstract void PrimitiveOperation2(); // Implementated by concrete subclasses

    protected void ConcreteOperation() // Common method. The subclasses can't override it
    {
        Console.WriteLine("Common operation for all subclasses");
    }

    protected virtual void Hook() { } // Hook: A concrete method but it does nothing. Subclasses are free to override this but don't have to.
}
