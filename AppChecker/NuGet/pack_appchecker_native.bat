.\tools\nuget.exe pack appchecker.native.nuspec

copy /Y *.nupkg  "C:\Dev\Local NuGet Repository\*"
pause