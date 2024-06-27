/// <summary>
/// The Object class
/// </summary>
class Obj {
    /// <summary>
    /// Returns if an object type is of a sub class
    /// </summary>
    /// <param name="derivedType"></param>
    /// <param name="baseType"></param>
    /// <returns></returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType) {
        if (derivedType.IsSubclassOf(baseType)) {
            return true;
        }
        return false;
    }
}
