using System.Net.Http.Headers;

/// <summary>
/// Vector math class
/// </summary>
class VectorMath {
    /// <summary>
    /// Method to add 2 vectors
    /// </summary>
    /// <param name="vector1"></param>
    /// <param name="vector2"></param>
    /// <returns>vector</returns>
    public static double[] Add(double[] vector1, double[] vector2) {

        if (vector1.Length != vector2.Length || (vector1.Length !=2 && vector1.Length != 3)) {
            return new double[] {-1}; 
        }
        double[] finalresult = new double[vector1.Length];
        for(int i = 0; i<vector1.Length; i++) {
            finalresult[i] = vector1[i] + vector2[i];
        };
        return finalresult;
    }
}

