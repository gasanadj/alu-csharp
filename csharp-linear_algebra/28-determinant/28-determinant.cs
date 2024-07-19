
/// <summary>
/// This is the class responsible for matrix mathematics
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Public method to perform the determinant of a matrix
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns></returns>
 public static double delta(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        if (rows != cols || (rows != 2 && rows != 3))
        {
            return -1;
        }

        if (rows == 2)
        {
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }
        else if (rows == 3)
        {
            double delta = 0;
            delta += matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]);
            delta -= matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]);
            delta += matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
            return delta;
        }

        return -1;
    }
}