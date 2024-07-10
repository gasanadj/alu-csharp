using System.Net.Http.Headers;

/// <summary>
/// Vector math class
/// </summary>
class VectorMath {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="vector1"></param>
    /// <param name="vector2"></param>
    /// <returns>vector</returns>
    public static double DotProduct(double[] vector1, double[] vector2) {
        if(vector1.Length != vector2.Length || (vector1.Length !=2 && vector2.Length !=3)) {
            return -1;
        }
        double[] final = new double[vector1.Length];
        for(int i = 0; i<vector1.Length; i++) {
            final[i] = vector1[i] * vector2[i];
        }
        double sum = 0;
        foreach(double el in final) {
            sum += el;
        }
        return sum;
    }
}

