
/// <summary>
/// This is the class responsible for matrix mathematics
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Public method to perform the transpose of a matrix
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns></returns>
public static double[,] Transpose(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[,] resultMatrix = new double[cols, rows];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                resultMatrix[j, i] = matrix[i, j];
            }
        }

        return resultMatrix;
    }
}