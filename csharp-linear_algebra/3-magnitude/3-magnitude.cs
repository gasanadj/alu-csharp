class VectorMath {
    public static double Magnitude(double[] vector) {
        if (vector.Length !=2 || vector.Length !=3) {
            return -1;
        }
        double sumSquares = 0;
        foreach(double el in vector) {
            sumSquares += el * el;
        }
        double lenSquare = Math.Sqrt(sumSquares);
        double len = Math.Round(lenSquare, 2);
        return len;

    }
}
