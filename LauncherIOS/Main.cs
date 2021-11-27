using Silk.NET.Windowing.Sdl.iOS;
using Template;
using Template.iOS;

// Initialize and run Core
SilkMobile.RunApp(args, (_) => new Core(new iOSPlatform()).Run());