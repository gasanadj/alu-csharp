using System.Net.Http.Headers;

/// <summary>
/// Vector math class
/// </summary>
class VectorMath {
    /// <summary>
    /// This performs scalar multiplication
    /// </summary>
    /// <param name="vector"></param>
    /// <param name="scalar"></param>
    /// <returns></returns>
    public static double[] Multiply(double[] vector, double scalar) {
        if (vector.Length !=2 && vector.Length !=3) {
            return new double[] {-1};
        }

        double[] final  = new double[vector.Length];
        for(int i = 0; i<vector.Length; i++) {
            final[i] = vector[i] * scalar;
        }
        return final;

    }
}

