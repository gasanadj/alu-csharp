/// <summary>
/// The object class
/// </summary>
class Obj {
    /// <summary>
    /// Method to check if an object is an instance of a class
    /// </summary>
    /// <param name="obj"></param>
    /// <returns>True | False</returns>
    public static bool IsInstanceOfArray(object obj) {
        if (obj is Array) {
            return true;
        }
        return false;
    }
}
