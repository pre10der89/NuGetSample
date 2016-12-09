dotnet restore
dotnet build -r osx.10.10-x64 -c RELEASE
dotnet build -r ubuntu.14.04-x64 -c RELEASE
dotnet build -r win10-arm -c RELEASE
dotnet build -r win10-x86 -c RELEASE
dotnet build -r win10-x64 -c RELEASE
dotnet build -r win8-arm -c RELEASE
dotnet build -r win8-x86 -c RELEASE
dotnet build -r win8-x64 -c RELEASE
dotnet build -r win7-x64 -c RELEASE
dotnet build -r win7-x86 -c RELEASE