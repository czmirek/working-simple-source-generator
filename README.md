# Working simple C# source generator (November 2020)
The simplest sample of the C# source generator.

I had troubles withthe official samples from the Roslyn repo so I created my own working example.

Important notes:
- The Generator project must be **netstandard2.0** (nothing else works)
- Latest versions of referenced analyzer nugets work
- You have to restart Visual Studio for Intellisense to capture the generated code

The official docs are here:
- https://devblogs.microsoft.com/dotnet/introducing-c-source-generators/
- https://devblogs.microsoft.com/dotnet/new-c-source-generator-samples/
