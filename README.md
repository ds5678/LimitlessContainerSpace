# Limitless Container Space

This is a mod for **The Long Dark** by Hinterland Games Studio, Inc. It raises the capacity on all containers to 10000 kilograms.

## [Patreon](https://www.patreon.com/ds5678)

I know many people might skip over this, but I hope you don't. You are so special, and I would appreciate your support. Modding takes lots of time, and I have expenses like food, internet, and rent. If you feel that I have improved your playing experience, please consider supporting me on my [Patreon](https://www.patreon.com/ds5678). Your support helps to ensure that I can continue making mods for you at the pace I am :)

## Installation

1. If you haven't done so already, install [MelonLoader](https://github.com/LavaGang/MelonLoader/releases/latest) (v0.7.2) into your TLD install directory.
2. Download the latest version of `LimitlessContainerSpace.dll` from the [releases page](https://github.com/ds5678/LimitlessContainerSpace/releases).
3. Move `LimitlessContainerSpace.dll` into the Mods folder in your TLD install directory.

## Building

Requires the .NET SDK (6.0 or newer). Game references come from the `STBlade.Modding.TLD.Il2CppAssemblies.Windows` NuGet package, so no local game files are needed.

```
dotnet build -c Release
```

The output is `bin/Release/net6.0/LimitlessContainerSpace.dll`. Built against TLD 2.55 and MelonLoader 0.7.2.
