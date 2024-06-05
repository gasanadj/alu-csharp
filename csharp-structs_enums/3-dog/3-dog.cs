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

    override public string ToString() {
        return $"Dog Name: {name}\nAge: {age}\nOwner: {owner}\nRating: {rating}";
    }
    public string name;
    public float age;
    public string owner;
    public Rating rating;
}