This sample solution is meant to demonstrate a possible bug wrt the JunitXMLLogger.
The behaviour described here only happens on MacOS. It works fine on Windows.

If you run the following command, there will be a JUnit report in the output folder.
```
dotnet test Example.sln --results-directory "./output" --logger "jUnit"
```
However, when you add the option to also cellect code coverage, the JUnit file will no longer be created:
```
dotnet test Example.sln --results-directory "./output" --logger "jUnit" --collect "Code Coverage"
```
