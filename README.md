# full-stack-dev-DIO
DIO Course - XP Inc. - Full Stack Developer - oct24

## dotNET Introduction
* It is an environment to implement microsoft projects in C# for example
* .net framework is obsolet (legado) and runs junst in Windows
* .net core is multiplatform and runs in Windows, Linux and Mac
* .net is the new name for .net core and it starts at version 5

### Extensions for .net and C# on Visual Studio
* .NET Install Tool - got from microsoft website
* C# Dev Kit - from microsoft website - to make the code understandable and enable debugging
* C# Extensions - JosKreativ - make it easier to create classes, stricts etc.
* vscode-icons - from VSCode Icons Team - create better icons to improve the visualization of the project items

### Projeto .net C#
* dotnet new console
* firstCsharp.csproj
    - Arquivo descritivo das propriedades do projeto
    - Feito em xml (usa <tag>tag<\tag> para as configurações)
    - Contém as propriedades que informam como o projeto deve se comportar
    <OutputType>Exe</OutputType> - Tipo de saída que gera arquivo executável
    <TargetFramework>net8.0</TargetFramework> - Versão do dotnet. Comando dotnet --info para ver quais estão instaladas
* Os arquivos de Debug são gerados na pasta obj
* Para buildar o código: dotnet build
    Os arquivos são gerados na pasta bin

### New class .net C#
* Organize by creating a new folder called Models
* Right click on Models and New C# -> class
* Inside the class, type prop to have the atribute template
* use the namespace to better organize the code
* when instanciate new class, call the name space like: using projectName.Models

### Names convention
* PascalCase: first letters cappital letter (upper case)
* camelCase: first letters lower case
* Do not abbreviate the attributes name
* Use the same file name for the class name
* Do not use special characters for the names (just undescore is allowed)
* Class name: PascalCase
* Method name: PascalCase
* Variable: camelCase

### Work with data - DateTime library
* DateTime.Now - The current date and time from system
* DateTime.AddDays(N) - Add N days to the current date

### Converting types
* Use the class Convert
    int a = Convert.ToInt32("5")
* All usual types have the method ToString() - varInt.ToString()
*
