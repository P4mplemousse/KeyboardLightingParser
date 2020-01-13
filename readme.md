# Keyboard Lighting Parser

## Purpose
This script parse user input for the custom Keyboard Lighting feature and prompt if any syntax error occurs.

>SteelSeries RGB keyboards have always featured eye-catching lighting effects. And although we very much enjoy handcrafting these lighting effects ourselves, we constantly receive requests from our most passionate and creative users, that they want a way to create their ​own awesome lighting effects. Welp, that day is almost upon us. We’ve already built a lighting engine that allows anyone to create custom lighting effects just by entering simple text strings into SteelSeries Engine. 

## How to build
This program is a console application that has been built with Visual Studio 17 v 15.9.15.

It depend on the .Net framework 4.6.1.

To build : 
1. load the *sln* file in visual studio.
2. Select *debug* or *release* build type.
3. On the build menu, choose *build the solution* (or hit ctrl+shift+b).

Once build, binaries can be found in */KeyboardLightingParser/bin/[debug|release]*.

## Usage
Double click on the exe or launch it from cmd/Powershell.

The program will ask for a file path or a folder path.

If every thing run right, it will display a report like this : 

    a, static, [red]
    b, static, [green]
    c, static, [green]
    d, wave, [red, blue]
    e, wave, [red, blue]
    f, wave, [red, blue]
    t, disco, [red, green, orange]
    u, disco, [red, green, orange]
    v, disco, [red, green, orange]

If any error occurs, it will display the error report like this :

    INVALID : Static effects are single color only

## Notes
The project contain the *test_files* folder. 

This folder is here for testing purpose and allow quick testing with several file.

It contain some sample.