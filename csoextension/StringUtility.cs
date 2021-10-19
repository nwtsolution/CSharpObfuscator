using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CSharpObfuscator.Extension
{
    public static class StringUtility
    {
        public static string EncodeStringArray(string project, string[] array)
        {   
            //implement your own encryption and encoding
            using (var ms = new MemoryStream())
            {
                new BinaryFormatter().Serialize(ms, array);
                return Convert.ToBase64String(ms.ToArray());
            }
        }
        public static string GetDecodeToStringArrayMethodName(string project)
        {
            //the full name of the decoding method in your project
            return "CSharpObfuscator.Utility.StringHelpers.DecodeToStringArray";
        }
    }
}

/*
namespace CSharpObfuscator.Utility
{
    public static class StringHelpers
    {
        public static string[] DecodeToStringArray(string content)
        {
            using (var ms = new MemoryStream(Convert.FromBase64String(content)))
                return (string[])new BinaryFormatter().Deserialize(ms);
        }
    }
}
*/
