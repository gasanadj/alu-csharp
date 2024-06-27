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