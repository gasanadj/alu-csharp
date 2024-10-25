using System;

/// <summary>
/// Player class
/// </summary>
public class Player {
    /// <summary>
    /// name property
    /// </summary>
    public string? name {get; set;}
    /// <summary>
    /// maxHp property
    /// </summary>
    public float? maxHp {get; set;}
    /// <summary>
    /// hp property
    /// </summary>
    public float? hp {get; set;}
    /// <summary>
    /// Constructor
    /// </summary>
    public Player(string name = "Player", float maxHp = 100f) {
        this.name = name;
        if (maxHp > 0) {
            this.maxHp = maxHp;
        }else {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        this.hp = maxHp;
    }
    /// <summary>
    /// Method to Print the Health of the Player
    /// </summary>
    public void PrintHealth() {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

}
