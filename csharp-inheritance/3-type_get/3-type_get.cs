#pragma warning disable CS8618 // Disable warning about non-nullable field not being initialized

using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary>
/// The Object class
/// </summary>
public class Obj
{
    /// <summary>
    /// prints the names of the available properties and methods of an object.
    /// </summary>
    /// <param name="myObj"></param>
    public static void Print(object myObj)
    {
        Type type = myObj.GetType();
        
        Console.WriteLine($"{type.Name} Properties:");
        foreach (PropertyInfo prop in type.GetProperties())
        {
            Console.WriteLine(prop.Name);
        }
        
        Console.WriteLine($"{type.Name} Methods:");
        foreach (MethodInfo method in type.GetMethods())
        {
            Console.WriteLine(method.Name);
        }
    }
}

#pragma warning restore CS8618 // Restore warning about non-nullable field not being initialized
