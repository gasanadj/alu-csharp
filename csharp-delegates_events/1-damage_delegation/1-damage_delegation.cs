using System;

/// <summary>
/// Player class
/// </summary>
public class Player {
    /// <summary>
    /// name property
    /// </summary>
    private string? name;
    /// <summary>
    /// maxHp property
    /// </summary>
    private float? maxHp;
    /// <summary>
    /// hp property
    /// </summary>
    private float? hp;
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
        hp = this.maxHp;
    }
    /// <summary>
    /// Method to Print the Health of the Player
    /// </summary>
    public void PrintHealth() {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
    /// <summary>
    /// Delegate function
    /// </summary>

    public delegate void CalculateHealth(float value);
    /// <summary>
    /// Take Damage function
    /// </summary>
    /// <param name="damage"></param>
    public void TakeDamage(float damage) {
        if (damage < 0) {
            Console.WriteLine($"{name} takes 0 damage!");
        } else {
            Console.WriteLine($"{name} takes {damage} damage!");
        }
        
    }
    /// <summary>
    /// Heal damage function
    /// </summary>
    /// <param name="heal"></param>
    public void HealDamage(float heal) {
        if (heal < 0) {
            Console.WriteLine($"{name} heals 0 HP!");
        }else {
            Console.WriteLine($"{name} heals {heal} HP!");
        }

    }

}
