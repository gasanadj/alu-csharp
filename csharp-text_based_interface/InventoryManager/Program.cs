﻿using System;
using InventoryLibrary;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Runtime.InteropServices;
using System.Text.Json;

namespace InventoryManager;

/// <summary>
/// The main entry to the program
/// </summary>
public class Program {
    /// <summary>
    /// Json stoage Instance
    /// </summary>
    public static JSONStorage jSONStorage = new();
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
                        ListClassNames();
                        break;
                    case "all":
                        ShowAll(commandParts.Length > 1 ? commandParts[1] : null!);
                        break;
                    case "create":
                        if (commandParts.Length < 2) Console.WriteLine("Please Specify Class Name");
                        else CreateObject(commandParts[1]);
                        break;
                    case "show":
                        if (commandParts.Length < 3) Console.WriteLine("Please Specify Class Name and Object ID");
                        else ShowObject(commandParts[1], commandParts[2]);
                        break;
                    case "update":
                        if (commandParts.Length < 3) Console.WriteLine("Please Specify Class Name and Object ID");
                        else UpdateObject(commandParts[1], commandParts[2]);
                        break;
                    case "delete":
                        if (commandParts.Length < 3) Console.WriteLine("Please Specify Class Name and Object ID");
                        else DeleteObject(commandParts[1], commandParts[2]);
                        break;
                    case "exit":
                        Console.WriteLine("Exiting Inventory Manager");
                        return;
                    default:
                        Console.WriteLine("Invalid Command. Please Try again!");
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

    /// <summary>
    /// Method to print the commands for the CLI
    /// </summary>
    public static void PrintCommands() {
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

    /// <summary>
    /// Method to List the names of the available classes
    /// </summary>
    public static void ListClassNames() {
        var classnames = new HashSet<string>();
        Console.WriteLine("Classes Present");
        Console.WriteLine("***************************************");
        Console.WriteLine("- User");
        Console.WriteLine("- Item");
        Console.WriteLine("- Inventory");

        // foreach (var key in jSONStorage.All().Keys) {
        //     string classname = key.Split('.')[0];
        //     classnames.Add(classname);
        // }

        // foreach (var name in classnames) {
        //     Console.WriteLine(name);
        // }
    }
    /// <summary>
    /// Method to show all Items in the inventory
    /// </summary>
    /// <param name="classname"></param>

    public static void ShowAll(string classname = null!) {
        if (jSONStorage.All().Count > 0) {
            foreach (var entry in jSONStorage.All()) {
            if (classname == null || entry.Key.StartsWith(classname, StringComparison.OrdinalIgnoreCase)) {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
        } else {
            Console.WriteLine("Our Inventory is Currently Empty");
        }
    }
    /// <summary>
    /// Method to create an object of a given class
    /// </summary>
    /// <param name="className"></param>
    public static void CreateObject(string className) {
        switch(className.ToLower()) {
        case "item":
            Console.Write("Enter name: ");
            string itemName = Console.ReadLine()!;
            var item = new Item(itemName);

            Console.Write("Enter description (optional): ");
            string? itemDescription = Console.ReadLine();
            if (!string.IsNullOrEmpty(itemDescription)) item.Description = itemDescription;

            Console.Write("Enter price (optional): ");
            if (float.TryParse(Console.ReadLine(), out float itemPrice)) item.Price = itemPrice;

            Console.Write("Enter tags (comma-separated, optional): ");
            string itemTags = Console.ReadLine()!;
            if (!string.IsNullOrEmpty(itemTags)) item.Tags = new List<string>(itemTags.Split(','));

            jSONStorage.New(item);
            jSONStorage.Save();
            Console.WriteLine($"Created new {className} with ID {item.id}");
            break;
            case "user":
                Console.Write("Enter user name: ");
                var uname = Console.ReadLine()!;
                var user = new User(uname);
                jSONStorage.New(user);
                jSONStorage.Save();
                break;
            case "inventory":
                    CreateInventory();
                    break;
            
            default:
                Console.WriteLine($"{className} is not a valid object type.");
                break;
        }
    }

    /// <summary>
    /// Method to show a particular object from a given class with it's ID
    /// </summary>
    /// <param name="classname"></param>
    /// <param name="id"></param>
    public static void ShowObject(string classname, string id) 
    {
        string capitalizedClassName = char.ToUpper(classname[0]) + classname[1..];
        string key = $"{capitalizedClassName}.{id}";

        if (jSONStorage.All().TryGetValue(key, out var obj)) 
        {
            string json = JsonSerializer.Serialize(obj, new JsonSerializerOptions { WriteIndented = true });
            Console.WriteLine($"{key}: {json}");
        } 
        else 
        {
            Console.WriteLine($"Object {id} could not be found");
        }
    }

    /// <summary>
    /// Method to Update a given object
    /// </summary>
    /// <param name="className"></param>
    /// <param name="id"></param>
    public static void UpdateObject(string className, string id)
    {
        // Capitalize the first letter of className to match stored format
        string capitalizedClassName = char.ToUpper(className[0]) + className[1..];
        string key = $"{capitalizedClassName}.{id}";

        Console.WriteLine($"Looking for key: {key}");

        if (jSONStorage.All().TryGetValue(key, out var obj))
        {
            if (obj is JsonElement jsonElement)
            {
                switch (capitalizedClassName)
                {
                    case "Item":
                        var item = JsonSerializer.Deserialize<Item>(jsonElement.GetRawText());
                        if (item != null)
                        {
                            Console.Write("Enter new description (leave blank to skip): ");
                            string description = Console.ReadLine()!;
                            if (!string.IsNullOrEmpty(description)) item.Description = description;

                            Console.Write("Enter new price (leave blank to skip): ");
                            if (float.TryParse(Console.ReadLine(), out float price)) item.Price = price;

                            jSONStorage.Save(item,key);
                            Console.WriteLine($"{capitalizedClassName} {id} updated.");
                        }
                        break;

                    case "User":
                        var user = JsonSerializer.Deserialize<User>(jsonElement.GetRawText());
                        if (user != null)
                        {
                            Console.Write("Enter new user name (leave blank to skip): ");
                            string newName = Console.ReadLine()!;
                            if (!string.IsNullOrEmpty(newName)) user.Name = newName;

                            jSONStorage.Save(user, key);
                            Console.WriteLine($"{capitalizedClassName} {id} updated.");
                        }
                        break;

                    case "Inventory":
                        var inventory = JsonSerializer.Deserialize<Inventory>(jsonElement.GetRawText());
                        Console.WriteLine(inventory);
                        if (inventory != null)
                        {
                            Console.Write("Enter new inventory quantity (leave blank to skip): ");
                            if (int.TryParse(Console.ReadLine(), out int quantity)) inventory.Quantity = quantity;

                            jSONStorage.Save(inventory, key);
                            Console.WriteLine($"{capitalizedClassName} {id} updated.");
                        }
                        break;

                    default:
                        Console.WriteLine($"{capitalizedClassName} {id} is not updatable.");
                        break;
                }
            }
            else
            {
                Console.WriteLine(obj.GetType());
                Console.WriteLine($"Object {id} could not be deserialized.");
            }
        }
        else
        {
            Console.WriteLine($"Object {id} could not be found.");
        }
    }


// static void UpdateObject(string className, string id)
// {
//     // Capitalize the first letter of className to match stored format
//     string capitalizedClassName = char.ToUpper(className[0]) + className.Substring(1);
//     string key = $"{capitalizedClassName}.{id}";

//     Console.WriteLine($"Looking for key: {key}");

//     if (jSONStorage.All().TryGetValue(key, out var obj))
//     {
//         Console.WriteLine(obj.GetType());
//         if (obj is Item item)
//         {
//             Console.Write("Enter new description (leave blank to skip): ");
//             string description = Console.ReadLine()!;
//             if (!string.IsNullOrEmpty(description)) item.Description = description;

//             Console.Write("Enter new price (leave blank to skip): ");
//             if (float.TryParse(Console.ReadLine(), out float price)) item.Price = price;

//             jSONStorage.Save();
//             Console.WriteLine($"{capitalizedClassName} {id} updated.");
//         }
//         else if (obj is User user)
//         {
//             // Handle User-specific updates
//             Console.Write("Enter new user name (leave blank to skip): ");
//             string newName = Console.ReadLine()!;
//             if (!string.IsNullOrEmpty(newName)) user.Name = newName;

//             jSONStorage.Save();
//             Console.WriteLine($"{capitalizedClassName} {id} updated.");
//         }
//         else if (obj is Inventory inventory)
//         {
//             // Handle Inventory-specific updates
//             Console.Write("Enter new inventory quantity (leave blank to skip): ");
//             if (int.TryParse(Console.ReadLine(), out int quantity)) inventory.Quantity = quantity;

//             jSONStorage.Save();
//             Console.WriteLine($"{capitalizedClassName} {id} updated.");
//         }
//         else
//         {
//             Console.WriteLine($"{capitalizedClassName} {id} is not updatable.");
//         }
//     }
//     else
//     {
//         Console.WriteLine($"Object {id} could not be found.");
//     }
// }



    // static void UpdateObject(string className, string id)
    // {
    //     string capitalizedClassName = char.ToUpper(className[0]) + className[1..];
    //     string key = $"{capitalizedClassName}.{id}";
    //     Console.WriteLine($"Looking for key: {key}");
    //     if (jSONStorage.All().TryGetValue(key, out var obj))
    //     {
    //         switch (obj)
    //         {
    //             case Item item:
    //                 // Update Item-specific properties
    //                 Console.Write("Enter new description (leave blank to skip): ");
    //                 string description = Console.ReadLine()!;
    //                 if (!string.IsNullOrEmpty(description)) item.Description = description;

    //                 Console.Write("Enter new price (leave blank to skip): ");
    //                 if (float.TryParse(Console.ReadLine(), out float price)) item.Price = price;

    //                 Console.Write("Enter new tags (comma-separated, leave blank to skip): ");
    //                 string tags = Console.ReadLine()!;
    //                 if (!string.IsNullOrEmpty(tags)) item.Tags = new List<string>(tags.Split(','));

    //                 Console.WriteLine($"{className} {id} updated.");
    //                 break;

    //             case Inventory inventory:
    //                 // Update Inventory-specific properties
    //                 Console.Write("Enter new UserId (leave blank to skip): ");
    //                 string userId = Console.ReadLine()!;
    //                 if (!string.IsNullOrEmpty(userId)) inventory.UserId = userId;

    //                 Console.Write("Enter new ItemId (leave blank to skip): ");
    //                 string itemId = Console.ReadLine()!;
    //                 if (!string.IsNullOrEmpty(itemId)) inventory.ItemId = itemId;

    //                 Console.Write("Enter new Quantity (leave blank to skip): ");
    //                 if (int.TryParse(Console.ReadLine(), out int quantity) && quantity >= 0)
    //                 {
    //                     inventory.Quantity = quantity;
    //                 }
    //                 else
    //                 {
    //                     Console.WriteLine("Invalid quantity. Quantity must be 0 or more.");
    //                 }

    //                 Console.WriteLine($"{className} {id} updated.");
    //                 break;

    //             case User user:
    //                 // Update User-specific properties
    //                 Console.Write("Enter new username (leave blank to skip): ");
    //                 string username = Console.ReadLine()!;
    //                 if (!string.IsNullOrEmpty(username)) user.Name = username;

    //                 Console.WriteLine($"{className} {id} updated.");
    //                 break;

    //             default:
    //                 Console.WriteLine($"{className} {id} is not updatable.");
    //                 break;
    //         }

    //         // Save changes to storage
    //         jSONStorage.Save();
    //     }
    //     else
    //     {
    //         Console.WriteLine($"Object {id} could not be found.");
    //     }
    // }

    /// <summary>
    /// Method to Delete an Item from inventory
    /// </summary>
    /// <param name="classname"></param>
    /// <param name="id"></param>
    public static void DeleteObject(string classname, string id) {
        // Capitalize the first letter of className to match stored format
        string capitalizedClassName = char.ToUpper(classname[0]) + classname[1..];
        string key = $"{capitalizedClassName}.{id}";
        
        if (jSONStorage.All().Remove(key)) {
            jSONStorage.Save();
            Console.WriteLine($"{classname} {id} deleted");
        } else {
            Console.WriteLine($"Object {id} could not be found");
        }
    }
    /// <summary>
    /// Method to create inventory
    /// </summary>
        private static void CreateInventory()
    {
        Console.Write("Enter user id: ");
        var userId = Console.ReadLine()!;
        if (!UserExists(userId))
        {
            Console.WriteLine("Error: User ID does not exist.");
            return;
        }

        Console.Write("Enter item id: ");
        var itemId = Console.ReadLine()!;
        if (!ItemExists(itemId))
        {
            Console.WriteLine("Error: Item ID does not exist.");
            return;
        }

        Console.Write("Enter quantity: ");
        if (!int.TryParse(Console.ReadLine(), out int quantity) || quantity < 0)
        {
            Console.WriteLine("Error: Quantity must be a non-negative integer.");
            return;
        }
        var newInventory = new Inventory(userId, itemId, quantity);
        jSONStorage.New(newInventory);
        jSONStorage.Save();
    }

    // Method to check if a user exists
    private static bool UserExists(string userId)
    {
        return jSONStorage.All().ContainsKey($"User.{userId}");
    }

    // Method to check if an item exists
    private static bool ItemExists(string itemId)
    {
        return jSONStorage.All().ContainsKey($"Item.{itemId}");
    }
    /// <summary>
    /// Testing tests
    /// </summary>
    /// <returns></returns>
    public string PrintTestMessage() {
        return "Hello World";
    }

}