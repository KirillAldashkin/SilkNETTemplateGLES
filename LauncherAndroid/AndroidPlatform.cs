using Silk.NET.OpenGLES;
using Silk.NET.Windowing;

namespace Template.Android;

/// <summary>
/// Implementation of <see cref="Platform"/> for Android.
/// </summary>
public class AndroidPlatform : Platform
{
    IView view;
    public override GL CreateGL() => GL.GetApi(view ?? throw new Exception("View was not initialized"));

    public override IView CreateView() => view = Window.GetView(new()
    {
        API = new GraphicsAPI(ContextAPI.OpenGLES, new(2, 0))
    });
}