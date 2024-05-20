class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int [,] resultMatrix = new int[myMatrix.GetLength(0),myMatrix.GetLength(1)];

        for (int i = 0; i < myMatrix.GetLength(0); i++)
        {
            for (int j=0; j<myMatrix.GetLength(1); j++)
            {
                resultMatrix[i,j] = myMatrix[i,j] * myMatrix[i,j];
            }
        } 
        return resultMatrix;
    }
}
