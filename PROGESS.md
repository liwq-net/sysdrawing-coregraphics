This file describes the progress in code integration from the mac-playground contribution

Directly from master, not partial:

* Bitmap.cs - imported directly from master
* PrinterSettings.cs 
* PageSettings.cs
* Extensions
* Color
* KnownColors
* KnownColor
* Font.cs
* SystemFonts.cs
	- Had to create an iOS version, but this one is not complete (SystemFonts.ios.cs)
* Graphics-DrawImage.cs 
* Image.cs

On the first patch, fa17b7bb8140752280ff846d8fa97c7936cc1881, done everything up to
Color patch, next up Font.cs