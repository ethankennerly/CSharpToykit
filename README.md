# Visual Studio Test Runner for CSharp Toykit

You can run NUnit tests in Unity Editor. Unity 5.4 or newer includes NUnit. However, running Unity Editor tests get to be slow on a large project. To workaround that, here is an external runner. The external runner does not have access to Unity classes. It is intended for independent code.

Besides Visual Studio, there is also JetBrains Rider, which I've heard integrates better with Unity, yet Visual Studio Community is free.

## Installation

1. Install Visual Studio. This example uses Visual Studio 2017 Community.
1. Create new project. Example: "CSharpToykit".
    1. Add existing item to be tested. Example: `DataUtil.cs`
1. Open Visual Studio Installer.
    1. Open Tools and Extensions.
    1. Install .Net Core.
    1. Install .Net Framework.
1. New solution. Example name:  "CSharpToykit"
1. New project. Example name: "CSharpToykit.Tests"
    1. Class Library (.Net Framework)
    1. If you don't see an option of Class Library, then install C# desktop developer workload, and restart Visual Studio.
1. Production code is in one project. Test code is in another.
1. Select test project.
1. Open NuGet Package Manager.
    1. In Solution Explorer, right-click "CSharpToykit.Tests" project. Context menu "Manage NuGet Packages..."
1. Install NUnit 3 into the project.
1. Install NUnit 3 Adapter into the project.
    1. Add existing item containing tests. Example: `TestDataUtil.cs`
1. Add a reference from test code to production project.  <https://www.c-sharpcorner.com/article/project-reference-vs-dll-reference-in-visual-studio/>

## Running tests in Visual Studio

1. Open Visual Studio.
1. Open Tests Explorer.
1. Run all tests.

# Command-line.

## Installation

1. Install NUnit 3 Console into the project.
    1. Or:
    1. Install nuget command line.
    1. Install through nuget command line.

## Running tests from command-line

1. Build the DLL.
1. Run from your path or installation location. Example:

         NUnit.ConsoleRunner.3.8.0/tools/nunit3-console.exe CSharpToykit.Tests/bin/Debug/CSharpToykit.Tests.dll --noresult

