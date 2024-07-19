
/// <summary>
/// This is the class responsible for matrix mathematics
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Public method to perform Shear of a matrix
    /// </summary>
    /// <param name="matrix"></param>
    /// <param name="direction"></param>
    /// <param name="factor"></param>
    /// <returns></returns>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[,] resultMatrix = new double[rows, cols];
        if (rows != 2 || cols != 2)
        {
            return new double[,] { { -1 } };
        }

        double[,] shearMatrix;
        if (direction == 'x')
        {
            shearMatrix = new double[,] { { 1, factor }, { 0, 1 } };
        }
        else if (direction == 'y')
        {
            shearMatrix = new double[,] { { 1, 0 }, { factor, 1 } };
        }
        else
        {
            return new double[,] { { -1 } };
        }

        for (int i = 0; i < rows; i++)
        {

            for (int j = 0; j < cols; j++)
            {

                for (int k = 0; k < 2; k++)
                {
                    resultMatrix[i, j] += Math.Round(matrix[i, k] * shearMatrix[k, j], 2);
                }
            }
        }
        return resultMatrix;

    }
}