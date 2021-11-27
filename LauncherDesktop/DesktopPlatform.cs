using Silk.NET.Maths;
using Silk.NET.OpenGLES;
using Silk.NET.Windowing;

namespace Template.Desktop;

/// <summary>
/// Implementation of <see cref="Platform"/> for Desktop.
/// </summary>
public class DesktopPlatform : Platform
{
    IView view;
    public override GL CreateGL() =>  GL.GetApi(view ?? throw new Exception("View was not initialized"));

    public override IView CreateView() => view = Window.Create(new()
    {
        WindowState = WindowState.Maximized,
        API = new GraphicsAPI(ContextAPI.OpenGLES, new(2, 0)),
        Title = "Template"
    });
}