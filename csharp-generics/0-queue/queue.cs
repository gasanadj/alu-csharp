/// <summary>
/// Generic class Queue
/// </summary>
/// <typeparam name="T"></typeparam>
public class Queue<T>
{
    /// <summary>
    /// Method that returns the type of the Queue
    /// </summary>
    /// <returns></returns>
    public Type CheckType()
    {
        return typeof(T);
    }
}