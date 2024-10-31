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
            _quantity = value;
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

    /// <summary>
    /// Default constructor for serialization
    /// </summary>
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    public Inventory() { 
        
    }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
}