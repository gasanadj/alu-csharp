using System.Dynamic;

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
    public int durability {get; set;}

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

/// <summary>
/// Decoration Class
/// </summary>
public class Decoration : Base, IInteractive, IBreakable {

    /// <summary>
    /// Public Bool isQuestItem
    /// </summary>
    public bool isQuestItem;

    /// <summary>
    /// Durability implememntation
    /// </summary>
    public int durability {get; set;}

    /// <summary>
    /// Decoration Constructor
    /// </summary>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false) {
        this.name = name;
        if (durability <= 0) {
            throw new Exception("Durability must be greater than 0");
        } else {
            this.durability = durability;
        }
        this.isQuestItem = isQuestItem;
    }

    /// <summary>
    /// Interact implementation
    /// </summary>

    public void Interact() {
        if (durability <= 0) {
            Console.WriteLine($"The {name} has been broken.");
        } else {
            if (isQuestItem) {
            Console.WriteLine($"You look at the {name}. There's a key inside.");
            } 
            else {
            Console.WriteLine($"You look at the {name}. Not much to see here.");
            }
        }
    }

    /// <summary>
    /// Break implementation
    /// </summary>
    public void Break() {
        durability--;
        if (durability > 0) {
            Console.WriteLine($"You hit the {name}. It cracks.");
        } else if (durability == 0) {
            Console.WriteLine($"You smash the {name}. What a mess.");
        } else {
            Console.WriteLine($"The {name} is already broken.");
        }
    }
}

/// <summary>
/// The Key class
/// </summary>
public class Key: Base, ICollectable {
    /// <summary>
    /// IsCollected implementation
    /// </summary>
    public bool isCollected {get; set;}
    /// <summary>
    /// Public Constructor
    /// </summary>
    public Key(string name = "Key", bool isCollected = false) {
        this.name = name;
        this.isCollected = isCollected;
    }
    /// <summary>
    /// Collect Implementation
    /// </summary>
    public void Collect() {
        if (isCollected) {
            Console.WriteLine($"You have already picked up the {name}.");
        } else {
            isCollected = true;
            Console.WriteLine($"You pick up the {name}.");
        }
    }

}
/// <summary>
/// Room Objects class
/// </summary>
public class RoomObjects {
    /// <summary>
    /// This method takes a list of all objects, iterate through it, and execute methods depending on what interface that item implements. 
    /// </summary>
    public static void IterateAction(List<Base> roomObjects, Type type) {
        foreach(Base obj in roomObjects) {
            if (typeof(IInteractive).IsAssignableFrom(type)) {
                if (obj is IInteractive interactive) {
                    interactive.Interact();
                }
            }

            if (typeof(IBreakable).IsAssignableFrom(type)) {
                if (obj is IBreakable breakable) {
                    breakable.Break();
                }
            }

            if (typeof(ICollectable).IsAssignableFrom(type)) {
                if (obj is ICollectable collectable) {
                    collectable.Collect();
                }
            }
        }
    }
}