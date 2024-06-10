namespace Enemies {
    /// <summary>
    /// This is a Class representation of a zombie
    /// </summary>
    class Zombie {
        public int health;

        /// <summary>
        /// This is a constructor that sets the health to 0
        /// </summary>

        public Zombie() {
            health = 0;
        }

        ///<summary>
        /// This is a paramaterized constructor which gives health a value
        /// </summary>

        public Zombie(int value) {
            if (value < 0) {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }
    }
}