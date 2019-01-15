# Building C# Projects on Linux

## Introduction
MonoDevelop provides all the tools required to build `C#` projects on Linux. It comes with a graphical interface as well as command line programs to build and run `C#` programs.

## Building Programs
To build an `MSBuild` project files, type:
```bash
$xbuild <project_name>.csproj
```

## Running Programs
To run an executable file, type:
```bash
$mono <project_name>.exe
```

## Repository
All programs in this repository were build using the latest Flatpak version of [MonoDevelop for Fedora](https://fedoraproject.org/wiki/MonoDevelop).
