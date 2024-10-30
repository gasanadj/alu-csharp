using System;
using InventoryLibrary;
using System.Collections.Generic;

namespace InventoryManager;

/// <summary>
/// The main entry to the program
/// </summary>
public class Program {
    static JSONStorage jSONStorage = new();
    static void Main(string[] args) {
        jSONStorage.Load();
        Console.WriteLine("Inventory Manager\n-------------------------");
        PrintCommands();

        while (true) {
            Console.WriteLine("\nEnter Command: ");
            string input = Console.ReadLine()?.Trim()!;
            if (string.IsNullOrEmpty(input)) continue;

            string[] commandParts = input.Split(' ', 3, StringSplitOptions.RemoveEmptyEntries);
            string command = commandParts[0].ToLower();

            try
            {
                switch(command) {
                    case "classnames":
                        Console.WriteLine("Classnames");
                        break;
                }
            }
            catch (System.Exception ex)
            {
                
                Console.WriteLine($"Error: {ex.Message}");
            }
            PrintCommands();
        }
    } 

    static void PrintCommands() {
        Console.WriteLine("\nAvailable Commands:");
        Console.WriteLine("<ClassNames> show all ClassNames of objects");
        Console.WriteLine("<All> show all objects");
        Console.WriteLine("<All [ClassName]> show all objects of a ClassName");
        Console.WriteLine("<Create [ClassName]> a new object");
        Console.WriteLine("<Show [ClassName object_id]> an object");
        Console.WriteLine("<Update [ClassName object_id]> an object");
        Console.WriteLine("<Delete [ClassName object_id]> an object");
        Console.WriteLine("<Exit>");
    }
}