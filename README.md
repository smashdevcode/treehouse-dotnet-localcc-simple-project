
# Treehouse .NET Local Code Challenges Simple Project

This .NET console app project is intended as a simple test project to assist with testing .NET local code challenges.

The root of the repo contains an MSBuild file (`project.msbuild`) that will build the project, run all of the tests, and if all of the tests successfully pass creates a ZIP file (project.zip) containing all of the source code files located in the `src` folder.

To run the MSBuild script, execute the following command in the root of the repo:

```
msbuild project.msbuild
```

## Dependencies

The following packages need to be installed as dependencies in the test project in order to support xUnit and creating a ZIP file from the MSBuild script:

* xunit
* xunit.runner.console
* xunit.runner.msbuild
* FluentAssertions
* MSBuildTasks

## Overcoming xUnit's Lack of Support for User Messages

The xUnit core team remove support for user messages in the belief that doing so would result in more readable test code. See [https://github.com/xunit/xunit/issues/350](https://github.com/xunit/xunit/issues/350) for a related discussion on this issue.

Using the Fluent Assertions assertion library integrates with xUnit and brings back support for user messages.

For more information on the Fluent Assertions library, see [http://fluentassertions.com/](http://fluentassertions.com/).

## Running Tests from Within Visual Studio for Mac

Visual Studio for Mac doesn't support xUnit out of the box. To enable support for discovering and running xUnit tests in VS for Mac, install this extension:

[https://github.com/xunit/xamarinstudio.xunit](https://github.com/xunit/xamarinstudio.xunit)

## Running Tests from the Command Line

Run the following commands from the root of the repo to build the solution and run all tests in the test project:

```
msbuild src/HelloWorld.sln
mono src/packages/xunit.runner.console.2.2.0/tools/xunit.console.exe src/HelloWorldTests/bin/Debug/HelloWorldTests.dll
```
