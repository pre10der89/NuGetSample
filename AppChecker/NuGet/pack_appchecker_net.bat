nuget.exe pack appchecker.NET.nuspec

move /Y *.nupkg  "C:\Dev\Local NuGet Repository"
pause