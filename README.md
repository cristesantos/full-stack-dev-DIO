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
* Use TryParse to avoid errors and endup the program
* Use of the class Convert
    int a = Convert.ToInt32("5")
* Use of the Parse
* All usual types have the method ToString() - varInt.ToString()

### Solution and Code organization
* The solution can contain many projects related to the same issue. For example: a solution for a internet bank account with a project with basic classes, another project to make pix, another one to make automatic debt.
* Install the extension cs-code-solutions to make it easier to create and manage solutions
* To reference a project inside another one: right click on the csproject file that is going to use something from the other project, then click on Reference...
* The main method is implicit since NET6. You can see the "main" explicitly on .NET5 project

### Array
* Array
    int[] arrayInt = new int[3]
    arrayInt.Length
* Use foreach to walk through the array
    int counter;
    foreach(int value in arrayInt)
        Console.WriteLine(value);
        counter++;
    - it is similar to for(int counter = 0; counter < arrayInt.Length; couter++)
* Resize the arrayInt
    Array is a class with the method to resize that copies the array to a new address with new length
    int[] arrayIntDouble = Array.Resize(ref arrayInt, arrayInt.Length*2)
* Copy one array to another one
    Array.Copy(arrayInt, arrayIntDouble, arrayInt.Length)

### List
* The main difference to array is that you don´t need to resize ti include more elements. you just include and the list resizes itself.
    List<string> listString = new List<string>();
    listString.Add("MG")
    listString.Add("SP")
    listString.Add("BA")

    listString.Remove("SP")
* Better use foreach in place of for loop