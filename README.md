# csharp9-test

https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9

## TopLevel

https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9#top-level-statements

https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/main-and-command-args/top-level-statements

https://channel9.msdn.com/Shows/Visual-Studio-Toolbox/Getting-Started-with-Jupyter-Notebooks-in-VS-Code

https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/top-level-statements

Jupyter notebooks
Azure Functions & GitHub Actions


DEMO: only one line of code 

access modifier default(internal)

Only one top-level file
No other entry points
using directives
Namespaces and type definitions
args
await
return

Implicit entry point method
Top-level code contains	Implicit Main signature
await and return	static async Task<int> Main(string[] args)
await	static async Task Main(string[] args)
return	static int Main(string[] args)
No await or return	static void Main(string[] args)

IL
LinqPad


## Record types

https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9#record-types
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/records

1. Positional syntax for property definition
    public string LastName { get; init; }

2. Immutability

3. Value equality && Equality in inheritance hierarchies

4. Nondestructive mutation?

5. ToString() - Built-in formatting for display - PrintMembers 
class vs record 

6. Inheritance

2. using positional parameters
3. init Properties
4. immutable vs mutable vs with expressions