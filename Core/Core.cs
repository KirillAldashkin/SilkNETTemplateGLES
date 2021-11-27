using Silk.NET.Windowing;

namespace Template;

/// <summary>
/// A class that runs the cross-platform logic of the application.
/// </summary>
public class Core
{
    public readonly Platform platform;
    public Core(Platform platform) => this.platform = platform;
    IView view;
    public void Run()
    {
        // Begin of cross-platform logic here
        view = platform.CreateView();
        //view.Update += (delta) => throw new("Yay! It works!");
        view.Run();
    }
}