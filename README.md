# Pixels for Glory Extensions
Extensions used by Pixels for Glory libraries 

## Building
Nothing special.  Build from solution.

## Installation
From a build or downloaded release, copy the `Extensions.dll` to `[PROJECT DIR]\Assets\Plugins`.

If using the Pixels for Glory NuGet repository at http://pixelsforglory.azurewebsites.net/nuget, install the `PixelsForGlory.Extensions` package into your own class library project or install the `PixelsForGlory.Unity3D.Extensions` package into a Unity3D project.

## Usage
- IsAlmostZero
    
    Tests that a float is within a tolerance of zero:
    
        float zero = 0.0f;
        float AlmostZero = 0.0000000000000000000000000001f;
        float notZero = 0.00001f;
      
        zero.IsAlmostZero();         // True
        AlmostZero.IsAlmostZero();   // True
        notZero.IsAlmostZero();      // False
        notZero.IsAlmostZero(0.01f); // True
      
      
      
     
    
- IsAlmostEqualTo
	
    Tests that a float is within a tolerance of another float:
	
        float one = 1.0f;
        float oneish = 1.01f;
      
        one.IsAlmostEqualTo(one);          // True
        one.IsAlmostEqualTo(oneish);       // False
        one.IsAlmostEqualTo(oneish, 0.1f); // True
      
