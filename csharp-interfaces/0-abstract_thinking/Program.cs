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