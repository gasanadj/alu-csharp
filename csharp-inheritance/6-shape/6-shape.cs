/// <summary>
/// The Shape base class
/// </summary>
class Shape
{
    /// <summary>
    /// Virtual Area Method
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>
/// Class Rectangle inhereting Shape
/// </summary>
class Rectangle : Shape
{
    private int width;
    private int height;
    /// <summary>
    /// Setter for Width
    /// </summary>
    public int Width
    {
        get { return width; }
        set
        {
            if (value > 0)
            {
                width = value;
            }
            else
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
        }
    }
    /// <summary>
    /// Setter for Height
    /// </summary>

    public int Height
    {
        get { return height; }
        set
        {
            if (value > 0)
            {
                height = value;
            }
            else
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
        }
    }

}