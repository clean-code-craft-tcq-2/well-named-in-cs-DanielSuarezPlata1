dotnet restore
dotnet add TelCo.ColorCoder package Microsoft.CodeAnalysis.Metrics --version 3.3.0
pushd "%~dp0"
if exist Debug rd /s /q Debug
if exist Release rd /s /q Release

"%programfiles(x86)%\Microsoft Visual Studio\2019\Enterprise\MSBuild\Current\Bin\msbuild.exe" /t:Metrics

:exit
popd
