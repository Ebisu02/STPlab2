namespace STPlab2
{
    public class NotQuadraMatrixError : Exception
    {
        public NotQuadraMatrixError()
        {
        }

        public NotQuadraMatrixError(string? message) : base(message)
        {
        }
    }

    public class App
    {
        public static float getMinimum(float a, float b)
        {
            if (a <= b) { return a; }
            else { return b; }
        }
        public static float getMaximumFromMatrix(float[][] matrix)
        {
            float res = matrix[0][0];
            for (int i = 0; i < matrix.Length; ++i)
            {
                for (int j = 0; j < matrix[i].Length; ++j)
                {
                    res = matrix[i][j] > res ? matrix[i][j] : res;
                }
            }
            return res;
        }
        public static float getMaximumFromMatrixSideDiagonal(float[][] matrix)
        {
            if (matrix.Length != matrix[0].Length)
            {
                throw new NotQuadraMatrixError();
            }
            float res = matrix[0][0];
            for (int i = 0; i < matrix.Length; ++i)
            {
                for (int j = 0; j < matrix[i].Length - i; ++j)
                {
                    res = matrix[i][j] > res ? matrix[i][j] : res;
                }
            }
            return res;
        }
        public static void Main()
        {
            float[][] a = { new float[] { 1f, 2f, 3f },
                            new float[] { 1f, 2f, 5f },
                            new float[] { 1f, 4f, 6f } };
            Console.WriteLine(getMaximumFromMatrixSideDiagonal(a));
        }
    }
}
