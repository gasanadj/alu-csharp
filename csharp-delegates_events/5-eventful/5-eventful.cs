using System;
using System.Security.Cryptography;

/// <summary>
/// Player class
/// </summary>
public class Player {
    private string status;
    /// <summary>
    /// name property
    /// </summary>
    private string name;
    /// <summary>
    /// maxHp property
    /// </summary>
    private float maxHp;
    /// <summary>
    /// hp property
    /// </summary>
    private float hp;
    /// <summary>
    /// Constructor
    /// </summary>
    /// 
    public Player(string name = "Player", float maxHp = 100f) {
        this.name = name;
        status = $"{name} is ready to go!";
        if (maxHp > 0) {
            this.maxHp = maxHp;
        }else {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        hp = this.maxHp;
        HPCheck += CheckStatus!;
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
            float newHp = hp - damage;
            Console.WriteLine($"{name} takes {damage} damage!");
            ValidateHP(newHp);
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
            float newHp = hp + heal;
            Console.WriteLine($"{name} heals {Math.Round(heal,1)} HP!");
            ValidateHP(newHp);
        }

    }
    /// <summary>
    /// Method to validate HP
    /// </summary>
    /// <param name="newHp"></param>
    public void ValidateHP(float newHp) {
        if (newHp < 0) {
            hp = 0;
        } else if (newHp > maxHp) {
            hp = maxHp;
        } else {
            hp = newHp;
        }

        OnCheckStatus(new CurrentHPArgs(hp));
    }

/// <summary>
/// Apply Modifier Function
/// </summary>
/// <param name="baseV"></param>
/// <param name="mod"></param>
/// <returns></returns>
    public float ApplyModifier(float baseV, Modifier mod) {
        if (mod == Modifier.Weak) {
            return baseV / 2;
        } else if (mod == Modifier.Base) {
            return baseV;
        } else {
            return baseV * 1.5f;
        }
    }
    /// <summary>
    /// Event Handler of Type CurrentHPArgs
    /// </summary>
    public EventHandler<CurrentHPArgs> HPCheck;
    /// <summary>
    /// Check status function
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void CheckStatus(object sender, CurrentHPArgs e) {
        if(e.currentHp == maxHp){
            status = $"{name} is in perfect health!";
            Console.WriteLine($"{name} is in perfect health!");
        }

        else if(e.currentHp >= (maxHp * 0.5) && e.currentHp < maxHp){
            status = $"{name} is doing well!";
            Console.WriteLine($"{name} is doing well!");
        }

        else if(e.currentHp >= (maxHp * 0.25) && e.currentHp < maxHp){
            status = $"{name} isn't doing too great...";
            Console.WriteLine($"{name} isn't doing too great...");
        }

        else if(e.currentHp > 0 && e.currentHp <= (0.25 * maxHp)){
            status = $"{name} needs help!";
            Console.WriteLine($"{name} needs help!");
        }

        else if(e.currentHp == 0){
            status = $"{name} is knocked out!";
            Console.WriteLine($"{name} is knocked out!");
        }
    }

    private void HPValueWarning(object sender, CurrentHPArgs e) {
        if (e.currentHp == 0) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Health has reached zero!");
            Console.ResetColor();
        } else {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Health is low!");
            Console.ResetColor();
        }
    }

    private void OnCheckStatus(CurrentHPArgs e) {
        if (e.currentHp < maxHp * 0.25f) {
            HPCheck += HPValueWarning!;
        }
        HPCheck?.Invoke(this, e);
    }

}
/// <summary>
/// Modifier Enum to store values
/// </summary>
public enum Modifier {
    /// <summary>
    /// Weak level
    /// </summary>
    Weak,
    /// <summary>
    /// Base level
    /// </summary>
    Base,
    /// <summary>
    /// Strong level
    /// </summary>
    Strong

}
/// <summary>
/// Delegate to Calculate Modifier
/// </summary>
/// <param name="baseValue"></param>
/// <param name="modifier"></param>
/// <returns></returns>

public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// CurrentHPArgs Class
/// </summary>
public class CurrentHPArgs : EventArgs {
    /// <summary>
    /// Current HP
    /// </summary>
    public float currentHp {get;}
    /// <summary>
    /// Constructor function
    /// </summary>
    public CurrentHPArgs(float newHp) {
        currentHp = newHp;
    }
}
