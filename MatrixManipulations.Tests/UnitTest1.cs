using System;
using NUnit.Framework;

namespace MatrixManipulations.Tests
{
    public class MatrixExtensionTests
    {
        [TestFixture]
        public class SpiralMatrixTest
        {
            [Test]
            public void GetMatrixTest_Trivial_Spiral()
            {
                var expected = new[,]
                {
                    {1}
                };
                Assert.AreEqual(expected, MatrixExtension.GetMatrix(1));
            }

            [Test]
            public void GetMatrixTest_Spiral_Of_Size_2()
            {
                var expected = new[,]
                {
                    {1, 2},
                    {4, 3}
                };
                Assert.AreEqual(expected, MatrixExtension.GetMatrix(2));
            }

            [Test]
            public void GetMatrixTest_Spiral_Of_Size_3()
            {
                var expected = new[,]
                {
                    {1, 2, 3},
                    {8, 9, 4},
                    {7, 6, 5}
                };
                Assert.AreEqual(expected, MatrixExtension.GetMatrix(3));
            }

            [Test]
            public void GetMatrixTest_Spiral_Of_Size_4()
            {
                var expected = new[,]
                {
                    {1, 2, 3, 4},
                    {12, 13, 14, 5},
                    {11, 16, 15, 6},
                    {10, 9, 8, 7}
                };
                Assert.AreEqual(expected, MatrixExtension.GetMatrix(4));
            }

            [Test]
            public void GetMatrixTest_Spiral_Of_Size_5()
            {
                var expected = new[,]
                {
                    {1, 2, 3, 4, 5},
                    {16, 17, 18, 19, 6},
                    {15, 24, 25, 20, 7},
                    {14, 23, 22, 21, 8},
                    {13, 12, 11, 10, 9}
                };
                Assert.AreEqual(expected, MatrixExtension.GetMatrix(5));
            }

            [Test]
            public void GetMatrixTest_Spiral_Of_Size_8()
            {
                var expected = new[,]
                {
                    {1, 2, 3, 4, 5, 6, 7, 8},
                    {28, 29, 30, 31, 32, 33, 34, 9},
                    {27, 48, 49, 50, 51, 52, 35, 10},
                    {26, 47, 60, 61, 62, 53, 36, 11},
                    {25, 46, 59, 64, 63, 54, 37, 12},
                    {24, 45, 58, 57, 56, 55, 38, 13},
                    {23, 44, 43,  42, 41, 40, 39, 14},
                    {22, 21, 20, 19, 18, 17, 16, 15}
                };
                Assert.AreEqual(expected, MatrixExtension.GetMatrix(8));
            }

            [TestCase(-100)]
            [TestCase(0)]
            public void GetMatrixTest_Throw_ArgumentException_If_Size_Is_Negative(int size)
            {
                Assert.Throws<ArgumentException>(() =>
                        MatrixExtension.GetMatrix(size), $"Size of matrix '{size}' cannot be less or equal zero.");
            }
        }
    }
}