/// <summary>
/// The Obj Class
/// </summary>
class Obj {
    /// <summary>
    /// Method to check if an object is of type int
    /// </summary>
    /// <param name="obj"></param>
    /// <returns>True | False</returns>
    public static bool IsOfTypeInt(object obj) {
        if (obj is int) {
            return true;
        } 
        return false;
    }
}
