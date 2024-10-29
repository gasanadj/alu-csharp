namespace InventoryLibrary;

/// <summary>
/// The Inventory class
/// </summary>
public class Inventory: BaseClass {
    /// <summary>
    /// UserId
    /// </summary>
    public string UserId {get; set;}
    /// <summary>
    /// ItemId
    /// </summary>
    public string ItemId {get; set;}
    private int _quantity;
    /// <summary>
    /// Quantity
    /// </summary>
    public int Quantity {
        get => _quantity;
        set {
            if (value < 0) {
                throw new ArgumentOutOfRangeException("Quantity can't be negative");
            }
            _quantity = 0;
        }
    }
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="uid"></param>
    /// <param name="iid"></param>
    /// <param name="qty"></param>
    public Inventory(string uid, string iid, int qty) {
        UserId = uid;
        ItemId = iid;
        Quantity = qty;
    }
}