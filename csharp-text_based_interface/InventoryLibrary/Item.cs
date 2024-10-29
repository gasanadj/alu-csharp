using System.Collections.Generic;

namespace InventoryLibrary
{
    /// <summary>
    /// Item Class
    /// </summary>
    public class Item : BaseClass
    {
        /// <summary>
        /// Name - required property
        /// </summary>
        public string Name { get; set; } 

        /// <summary>
        /// Description - optional property
        /// </summary>
        public string? Description { get; set; } 

        /// <summary>
        /// Price - optional property, limited to 2 decimal points
        /// </summary>
        private float? _price; 
        /// <summary>
        /// Price Property
        /// </summary>
        public float? Price
        {
            get => _price;
            set
            {
                if (value.HasValue)
                {
                    _price = (float)Math.Round(value.Value, 2); 
                }
                else
                {
                    _price = null; 
                }
            }
        }

        /// <summary>
        /// Tags - optional property
        /// </summary>
        public List<string> Tags { get; set; } = new List<string>(); 

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">The name of the item</param>
        public Item(string name)
        {
            Name = name; // Required property initialized
        }
    }
}
