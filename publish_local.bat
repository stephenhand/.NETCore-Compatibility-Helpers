@echo off


set PACKAGE_VERSION=0.0.0.2

if not exist publish mkdir publish   || exit /b 1

nuget list Handy.DotNETCore-Compatibility.ColorTranslations | findstr /e %PACKAGE_VERSION%
if %errorlevel% == 0 (
    echo Handy.DotNETCore-Compatibility.ColorTranslations version %PACKAGE_VERSION% already published
) else (
	echo publishing Handy.DotNETCore-Compatibility.ColorTranslations
	nuget pack ColorTranslations.nuspec -OutputDirectory  publish -Symbols -Version %PACKAGE_VERSION%
	nuget push publish/Handy.DotNETCore-Compatibility.ColorTranslations.%PACKAGE_VERSION%.nupkg -s http://localhost:49928/
)
