namespace MyMath;

///<summary>
/// public class which has all the matrix operations
///</summary>
public class Matrix
{
    ///<summary>
    /// Method which divides a matrix by an inreger
    ///</summary>
    public static int[,]? Divide(int[,] matrix, int num)
    {
        if (matrix == null)
        {
            return null;
        }
        int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
        try
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int div = matrix[i, j] / num;
                    newMatrix[i, j] = div;
                }
            }
        }
        catch (DivideByZeroException)
        {

            Console.WriteLine("Number cannot be 0");
            return null;
        }
        return newMatrix;
    }
}


