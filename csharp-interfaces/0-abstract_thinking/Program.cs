/// <summary>
/// Base Class
/// </summary>
public abstract class Base {
    /// <summary>
    /// The public property name
    /// </summary>
    public string? name;

    /// <summary>
    /// Override for the ToString()
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        Type type = name!.GetType();
        return $"{name} is a {type}";
    }
}