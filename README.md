# CSharp Obfuscator
 CSharp Obfuscator protects your .NET application code through obfuscation transforms, while maintaining debugging abilities for quality assurance testing. This is made possible by the [Roslyn](https://github.com/dotnet/roslyn) open source project. 
 
![obfuscation](img/cso.png?raw=true)

### Integrate with the existing development cycle
CSharp Obfuscator obfuscates your source code, so you can run full quality assurance tests even after your source code has been obfuscated, ensuring that your code is both tested and protected. It will also update Xamarin XAML files with the obfuscated code.

![flow](img/flow.gif?raw=true)

It can be seamlessly integrated with the exising development cycle when each c# project only targets one framework. If a c# project targets multiple framework, you need obfuscate the project for each framework seperately. 

### Versions

Both free and premium versions are available. Please check [NorWest Solution](https://www.nwtsolution.com/cso.html) for details.

### Command Line

    Usage: cso.exe [MSBuild options] [Options]
        
    MSBuild options: the same options when you use MSBuild.exe to build your solution.
  
    Options:
    -activate:account={account};sn={sn}        Activate your license
    -deactivate                                Deactivate your license
    -config:{file}                             A file containing the obfuscation configuration and rules
  
### Obfuscation Configuration File
- A text file that contains the obfuscation configuration and rules.
- Each configuration rule should be on a separate line.
- Any lines starting with a hash symbol (#) will be ignored.

#### Configuration

Name | Value | Note
-----|-------|-----
MSBuildPath|path of MSBuild.exe|Specify the path if you have more than one MSBuild.exe installed 
Obfuscate|all|By default, all public declarations will not be obfuscated. Use this option to obfuscate all declarations.
UseASCII|true|By default, declarations will be obfuscated with symbol characters. Use this option to obfuscate all declaration with ASCII characters.
Reserve|comma separated word list| Reserved keywords 
ASCII|comma separated word list| Use ASCII characters for the matched declaration
Suffix| any letter that is allowed to be used as a declaration name| The suffix of an obfuscated declaration.  
Prefix| any letter that is allowed to be used as a declaration name| The prefix of an obfuscated declaration.  
Reuse|true|Save the obfuscation result into a file (cso.db). Reuse the file for your next obfuscation.

#### Rules

Use rules to skip the obfuscation of matched declarations. Use the following format to define a rule:

    keep {declaration type} pattern
    
A pattern should be the fullname of a declaration and can use an asterisk (*) as the wildcard, such as

    keep namespace *.Tests

##### Available rules

    #keep declarations within the matched namespace
    keep namespace FullNameOfNamespace

    #keep the namespace name only
    keep namespace:name FullNameOfNamespace
    
    #keep declarations within the matched type, it could be a class, enum or interface
    keep type FullNameOfType
    
    #keep the type name only
    keep type:name FullNameOfType
    
    #keep declaration within the matched method
    keep method FullNameOfMethod
    
    #keep the method name only
    keep method:name FullNameOfMethod
    
    #keep method parameters
    keep method:parameter FullNameOfMethod
    
    #keep property
    keep property FullNameOfProperty
    
    #keep field variable 
    keep variable FullNameOfVariable
    
    #keep values of an enum
    keep enum:value FullNameOfEnum
    
    #does not support wildcard
    keep any CommaSeparatedWords

