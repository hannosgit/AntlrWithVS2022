
# Minimal Example for ANTLR with Visual Studio 2022

Two Packages are needed and the Antlr4 property has to point to the grammar file.
No other configuration should be needed to run this example according to the documentation of the build package:


> When added as a <PackageReference> to your C# project, Antlr4BuildTasks provides the rules to compile .g4's into parser code via the Antlr4 Tool using Java, and compiled by the C# compiler, for a seemless build for Antlr4 grammars using C#.
Antlr4BuildTasks automatically downloads a Java Runtime Environment (JRE) and the Antlr tool jar file to generate the parser and lexer. You do not need to set up anything. It can be used either at the command line or within Visual Studio, and on Windows, Linux or Mac. The JRE is only required to build your project, and never required or used after the build.

Project File:
```xml
	<ItemGroup>
		<PackageReference Include="Antlr4.Runtime.Standard" Version="4.11.1" />
		<PackageReference Include="Antlr4BuildTasks" Version="11.3.0" PrivateAssets="all" />
	</ItemGroup>
	<ItemGroup>
		<Antlr4 Include="grammar/antchat.g4" />
	</ItemGroup>
```

# Links

https://github.com/kaby76/Antlr4BuildTasks
