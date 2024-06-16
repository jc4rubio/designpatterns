namespace Bridge;

internal abstract class View(IResource resource)
{   
    protected readonly IResource Resource = resource; // Bridge between Views and Resources

    public abstract string Show();
}
