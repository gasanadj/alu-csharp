/// <summary>
/// Base Class
/// </summary>
public abstract class Base {
    /// <summary>
    /// The public property name
    /// </summary>
    public string ? name {get; set;}

    /// <summary>
    /// Override for the ToString()
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return $"{name} is a {this.GetType().Name}";
    }
}
/// <summary>
/// IInterface for interactivity
/// </summary>

public interface IInteractive {
    /// <summary>
    /// Method to Interact
    /// </summary>
    void Interact();
}

/// <summary>
/// IBreakable interface for durability
/// </summary>

public interface IBreakable {
    /// <summary>
    /// Public property durability
    /// </summary>
    int durability {get; set;}

    /// <summary>
    /// Break method 
    /// </summary>
    void Break();
}

/// <summary>
/// ICollectable Interface
/// </summary>
public interface ICollectable {
    /// <summary>
    /// Bool property isCollected
    /// </summary>
    bool isCollected {get; set;}

    /// <summary>
    /// Collect method
    /// </summary>
    void Collect() {

    }
}

// /// <summary>
// /// TestObject to test the functionalities
// /// </summary>
// public class TestObject : Base, IInteractive, IBreakable, ICollectable {
//     /// <summary>
//     /// Interact implementation
//     /// </summary>
//     public void Interact() {

//     }

//     /// <summary>
//     /// Interact implementation
//     /// </summary>
//     public void Break() {

//     }

//     /// <summary>
//     /// Durability implementation
//     /// </summary>
//     public int durability {
//         get {return durability;}
//         set {durability = value;}
//     }

//     /// <summary>
//     /// Collect implementation
//     /// </summary>
//     public void Collect() {

//     }

//     /// <summary>
//     /// Collect Implementation
//     /// </summary>
//     public bool isCollected {
//         get {return isCollected;}
//         set {isCollected = value;}
//     }

// }

/// <summary>
/// The Door Class
/// </summary>
public class Door : Base, IInteractive {
    /// <summary>
    /// Constructor
    /// </summary>
    public Door(string name = "Door") {
        this.name = name;
    }

    /// <summary>
    /// Interact implementation
    /// </summary>
    public void Interact() {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}