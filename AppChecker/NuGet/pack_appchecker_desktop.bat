.\tools\nuget.exe pack appchecker.desktop.nuspec

copy /Y *.nupkg  "C:\Dev\Local NuGet Repository\*"
pause