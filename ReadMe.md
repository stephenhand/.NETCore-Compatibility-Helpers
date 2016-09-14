This library is intended to be a toolkit of helpful classes for developers working with .NET Core. 

It will include some classes intended to provide functionality present in the .NET Framework but not currently implemented in Core libraries. 

It will also provide some adapter classes to try and present a consistent API for some functionality that is implemented differently in the 2 systems, useful when you need to maintain code that must be built target both platforms.

ColorTranslations.dll
-----------------

An 'el cheapo' colour translation utility class that converts a valid HTML colour identifier into a struct containing it's ARGB vector. 

Intended as a stand in for the same functionality in System.Drawing.ColorTranslator whilst the .NET Core team decide on a unified strategy to handling colours in this new platform

StandardLibrary.dll
-----------------

A toolkit of adapters and polyfills that aim to present a standard API for those developing code which needs to run on older versions of the .NET framework (v3.5+) and .NET Core

CultureInfoWrapper - Provides standard methods to get a CultureInfo object from an ISO code and for retrieving the current thread's culture & ui culture.

Streams - Provides a polyfill for 'GetBuffer' on MemoryStream

Arrays - Provides 'long' flavours of Array.Copy

Reflection - Provides standard methods to return type info for use in reflection from a type or an instance (Type in .NET Framework, TypeInfo in .NET Core)

IClonable - For replacing the same interface dropped in .NET Core if required