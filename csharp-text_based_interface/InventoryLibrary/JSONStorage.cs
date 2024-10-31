using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace InventoryLibrary;

/// <summary>
/// JSON Storage class for storing data
/// </summary>
public class JSONStorage {

    private readonly Dictionary<string, object> objects = new Dictionary<string, object>();
        private static readonly string directory = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, "InventoryLibrary", "storage"
        );
        
        private const string fileName = "inventory_manager.json";

    /// <summary>
    /// Returns the objects dictionary
    /// </summary>
    /// <returns></returns>
    public Dictionary<string, object> All() {
        return objects;
    }
    /// <summary>
    /// Method to add an object to dictionary
    /// </summary>
    /// <param name="obj"></param>
    public void New(object obj) {
        if (obj == null) throw new ArgumentNullException(nameof(obj));

        var className = obj.GetType().Name;
        var idProp = obj.GetType().GetProperty("id");
        var idValue = idProp?.GetValue(obj)?.ToString();
    
        if (string.IsNullOrEmpty(idValue)) {
            var idField = obj.GetType().GetField("id");
            idValue = idField?.GetValue(obj)?.ToString();
        }

        if (string.IsNullOrEmpty(idValue)) throw new InvalidOperationException("Object must have an ID");

        string key = $"{className}.{idValue}";
        objects[key] = obj;
    }


    /// <summary>
    /// Method to save the serialized data to a json file
    /// </summary>

    public void Save() {
        Directory.CreateDirectory(directory);
        string filePath = Path.Combine(directory, fileName);
        string json = JsonSerializer.Serialize(objects, new JsonSerializerOptions{
            WriteIndented = true,
        });
        File.WriteAllText(filePath, json);
    }
    

    /// <summary>
    /// Overloaded Save method to save a specific object to the in-memory collection and file.
    /// </summary>
    /// <param name="obj">The object to save or update.</param>
    /// <param name="key">The unique key associated with the object.</param>
    public void Save(object obj, string key) {
        // Update the in-memory collection with the specific object
        objects[key] = obj;

        // Call the general Save method to write all objects to the file
        Save();
    }
    /// <summary>
    /// Method to Load i.e Deserialize Data to objects
    /// </summary>
    public void Load() {
        string filePath = Path.Combine(directory, fileName);

        if (!File.Exists(filePath)) return;

        var json = File.ReadAllText(filePath);
        var data = JsonSerializer.Deserialize<Dictionary<string, object>>(json);

        if (data != null) {
            objects.Clear();
            foreach (var entry in data) {
                objects[entry.Key] = entry.Value;
            }
        }
    }

}