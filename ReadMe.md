This library is intended to be a toolkit of helpful classes for developers working with .NET Core. 

It will include some classes intended to provide functionality present in the .NET Framework but not currently implemented in Core libraries. 

It will also provide some adapter classes to try and present a consistent API for some functionality that is implemented differently in the 2 systems, useful when you need to maintain code that must be built target both platforms.

ColorTranslations.dll
-----------------

An 'el cheapo' colour translation utility class that converts a valid HTML colour identifier into a struct containing it's ARGB vector. 

Intended as a stand in for the same functionality in System.Drawing.ColorTranslator whilst the .NET Core team decide on a unified strategy to handling colours in this new platform