
# Xamarin Project Sample

This sample demonstrates how to use CSharp Obfuscator to obfuscate a Xamarin solution. The solution is copied from the [Xamarin.Forms Samples](https://github.com/xamarin/xamarin-forms-samples/tree/master/UserInterface/Xaminals) repository

## Steps to obfuscate

- Insatll the latest version of Visual Studio 2019.

- Restore referenced packages

      msbuild Xaminals.sln -t:restore -p:Configuration=Debug
    
- Build solution

      msbuild Xaminals.sln -t:rebuild -p:Configuration=Debug
    
- Obfuscate solution
    
      cso Xaminals.sln -t:rebuild -p:Configuration=Debug -Config:cso.cfg
      
- Check the obfuscation result      

