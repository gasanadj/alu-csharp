public enum Rating {
    Good,
    Great,
    Excellent
}

public struct Dog {
    public Dog(string x, float y, string z, Rating a) {
            name = x;
            age = y;
            owner = z;
            rating = a;
    }
    public string name;
    public float age;
    public string owner;
    public Rating rating;
}