using Silk.NET.OpenGLES;
using Silk.NET.Windowing;

namespace Template;

/// <summary>
/// Defines some things that any platform must implement.
/// </summary>
public abstract class Platform
{
    public abstract GL CreateGL();
    public abstract IView CreateView();
}