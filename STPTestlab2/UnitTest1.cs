using STPlab2;

namespace STPTestlab2
{
    [TestClass]
    public class Test_getMinimum
    {
        [TestMethod]
        public void test1_getMinimum()
        {
            float expected = 2.0f;
            float a = 2.0f;
            float b = 3.0f;
            Assert.AreEqual(expected, App.getMinimum(a, b));
        }
        [TestMethod]
        public void test2_getMinimum()
        {
            float expected = 2.0f;
            float a = 2.0f;
            float b = 2.0f;
            Assert.AreEqual(expected, App.getMinimum(a, b));
        }
        [TestMethod]
        public void test3_getMinimum()
        {
            float expected = 1.0f;
            float a = 1.0f;
            float b = 5.0f;
            Assert.AreEqual(expected, App.getMinimum(a, b));
        }
    }
    [TestClass]
    public class Test_getMaximumFromMatrix
    {
        [TestMethod]
        public void test1_getMaximumFromMatrix()
        {
            float[][] matrix =
            {
                new float[] { 1.0f, 2.0f, 3.33f },
                new float[] { 4.44f, 5.55f, 6.66f },
                new float[] { 7.77f, 8.88f, 9.99f },
                new float[] { 10.10f, 11.11f, 12.12f }
            };
            float expected = 12.12f;
            Assert.AreEqual(expected, App.getMaximumFromMatrix(matrix));
        }
        [TestMethod]
        public void test2_getMaximumFromMatrix()
        {
            float[][] matrix =
            {
                new float[] { 1.0f, 2.0f, 3.33f },
                new float[] { 4.44f, 5.55f, 6.66f },
                new float[] { 7.77f, 8.88f, 9.99f }
            };
            float expected = 9.99f;
            Assert.AreEqual(expected, App.getMaximumFromMatrix(matrix));
        }
        [TestMethod]
        public void test3_getMaximumFromMatrix()
        {
            float[][] matrix =
            {
                new float[] { 1.0f, 2.0f, 3.33f },
                new float[] { 4.44f, 5.55f, 6.66f }
            };
            float expected = 6.66f;
            Assert.AreEqual(expected, App.getMaximumFromMatrix(matrix));
        }
    }
    [TestClass]
    public class Test_getMaximumFromMatrixSideDiagonal
    {
        [TestMethod]
        public void test1_getMaximumFromMatrixSideDiagonal()
        {
            float[][] matrix =
            {
                new float[] { 1.0f, 2.0f, 3.33f },
                new float[] { 4.44f, 5.55f, 6.66f },
                new float[] { 7.77f, 8.88f, 9.99f },
                new float[] { 10.10f, 11.11f, 12.12f }
            };
            Assert.ThrowsException<NotQuadraMatrixError>(() =>
            {
                var e = App.getMaximumFromMatrixSideDiagonal(matrix);
            });
        }
        [TestMethod]
        public void test2_getMaximumFromMatrixSideDiagonal()
        {
            float[][] matrix =
            {
                new float[] { 1.0f, 2.0f, 3.33f },
                new float[] { 4.44f, 5.55f, 6.66f },
                new float[] { 7.77f, 8.88f, 9.99f }
            };
            float expected = 7.77f;
            Assert.AreEqual(expected, App.getMaximumFromMatrixSideDiagonal(matrix));
        }
        [TestMethod]
        public void test3_getMaximumFromMatrixSideDiagonal()
        {
            float[][] matrix =
            {
                new float[] { 1.0f, 2.0f, 3.33f },
                new float[] { 4.44f, 5.55f, 6.66f }
            };
            Assert.ThrowsException<NotQuadraMatrixError>( () =>
            {
                var e = App.getMaximumFromMatrixSideDiagonal(matrix);
            });
        }
    }
}