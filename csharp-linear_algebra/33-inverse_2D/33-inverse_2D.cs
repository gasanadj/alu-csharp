
/// <summary>
/// This is the class responsible for matrix mathematics
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Public method to perform the inverse of a 2D matrix
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns></returns>
    public static double[,] Inverse2D(double[,] matrix)

    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        if (rows != 2 || cols != 2)
        {
            return new double[,] { { -1 } };
        }
        double determinant = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];

        if (determinant == 0)
        {
            return new double[,] { { -1 } };
        }
        double[,] inverse = new double[2, 2];

        inverse[0, 0] = Math.Round(matrix[1, 1] / determinant,2);
        inverse[0, 1] = Math.Round(-matrix[0, 1] / determinant);
        inverse[1, 0] = Math.Round(-matrix[1, 0] / determinant);
        inverse[1, 1] = Math.Round(matrix[0, 0] / determinant);

        return inverse;
    }
}
