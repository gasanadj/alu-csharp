
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
        return Multiply(shearMatrix, matrix);
    }


    /// <summary>
    /// Public method to perform multiplication between two matrices.
    /// </summary>
    /// <param name="matrix1"></param>
    /// <param name="matrix2"></param>
    /// <returns></returns>
public static double[,] Multiply(double[,] matrix1, double[,] matrix2){
        if (matrix1.Length == 0 ||
            matrix2.Length == 0 ||
            matrix1.GetLength(1) != matrix2.GetLength(0)){
            return (new double[,]{{-1}});
        }
        var res = new double[matrix1.GetLength(0),matrix2.GetLength(1)];
        double sum = 0.0;
        for (int i = 0; i < matrix1.GetLength(0); i++){
            for (int j = 0; j < matrix2.GetLength(1); j++){
                sum = 0;
                for (int k = 0; k < matrix1.GetLength(1); k++){
                    sum = Math.Round(sum + (matrix1[i,k] * matrix2[k, j]), 2);
                }
                res[i, j] = Math.Round(sum, 2);
            }
        }
        return res;  
    }
}