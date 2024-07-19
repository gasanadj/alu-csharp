
/// <summary>
/// This is the class responsible for matrix mathematics
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Public method to perform scalar multiplication.
    /// </summary>
    /// <param name="matrix"></param>
    /// <param name="scalar"></param>
    /// <returns></returns>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        int rows1 = matrix.GetLength(0);
        int cols1 = matrix.GetLength(1);

        if (!((rows1 == 2 && cols1 == 2) || (rows1 == 3 && cols1 == 3)))
        {
            return new double[,] { { -1 } };
        }

        double[,] result = new double[rows1, cols1];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols1; j++)
            {
                result[i, j] = matrix[i, j] * scalar;
            }
        }
        return result;
    }
}