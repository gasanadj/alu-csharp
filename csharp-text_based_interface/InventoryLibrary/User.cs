namespace InventoryLibrary;

/// <summary>
/// User Class
/// </summary>
public class User : BaseClass {
    /// <summary>
    /// Name Property
    /// </summary>
    public string Name{get; set;}
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="name"></param>
    public User(string name) {
        Name = name;
    }


}