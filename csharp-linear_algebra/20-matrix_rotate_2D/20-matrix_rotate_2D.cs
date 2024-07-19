
/// <summary>
/// This is the class responsible for matrix mathematics
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Public method to perform multiplication between two matrices.
    /// </summary>
    /// <param name="matrix"></param>
    /// <param name="angle"></param>
    /// <returns></returns>
    public static double[,] Rotate2D(double[,] matrix, double angle){
        double cos = Math.Cos(angle);
        double sin = Math.Sin(angle);
        var rotation = new double[2,2]{{cos, sin}, {-sin, cos}};
        var res = new double[matrix.GetLength(0),matrix.GetLength(1)];
        res = Multiply(matrix, rotation);
        return res;
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