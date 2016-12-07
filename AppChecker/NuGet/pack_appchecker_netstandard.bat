.\tools\nuget.exe pack appchecker.netstandard.nuspec

copy /Y *.nupkg  "C:\Dev\Local NuGet Repository\*"
pause