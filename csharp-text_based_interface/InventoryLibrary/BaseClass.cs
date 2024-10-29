using System;
namespace InventoryLibrary;

/// <summary>
/// The BaseClass
/// </summary>
public class BaseClass
{
    /// <summary>
    /// Id
    /// </summary>
    public string id;
    /// <summary>
    /// The Date Created
    /// </summary>
    public DateTime date_created;
    /// <summary>
    /// The date Updated
    /// </summary>
    public DateTime date_updated;
    /// <summary>
    /// Constructor
    /// </summary>
    public BaseClass(){
        id = Guid.NewGuid().ToString();
        date_created = DateTime.Now;
        date_updated = DateTime.Now;
    }

}
