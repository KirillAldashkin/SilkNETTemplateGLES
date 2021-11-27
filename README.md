# OpenGL ES template
### About 
A simple and light template for using OpenGL ES on the desktop
(Windows/Linux/macOS) and mobile (Android/iOS) operating systems.
Uses [Silk.NET](https://github.com/dotnet/Silk.NET).
### Building
Building of this project has been tested only on Windows, running
of this project has been tested on Windows and Android.
Any [issues](https://github.com/KirillAldashkin/SilkNETTemplateGLES/issues)
are welcome!
#### Required
1) [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
2) `android` or `ios` workload to build an application for these 
operating systems:
```bash
dotnet workload install android # To build an application for Android
dotnet workload install ios # To build an application for iOS
```
#### Building
1) `cd` to some launcher project folder
2) Run `dotnet build` to build an application

NOTE: If you want to get a separate `.apk` file when building an 
Android launcher project, run `dotnet build -c Release`, `.apk`
file will be located in `$repo$\LauncherAndroid\bin\Release\net6.0-android\`.
If the release-build fails for any reason related to "linking", run
`dotnet build -c Release -p:PublishTrimmed=false`

#### Running
1) `cd` to some launcher project folder
2) Run `dotnet run` to build and run an application

NOTE: If you want to run an Android application, run
`dotnet run /p:_DeviceName:<UUID>`, where `<UUID>`
is a device id (you can get it running `adb devices`)