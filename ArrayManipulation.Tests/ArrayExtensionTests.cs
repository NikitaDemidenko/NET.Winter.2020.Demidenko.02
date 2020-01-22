using System;
using NUnit.Framework;
using static ArrayManipulation.ArrayExtension;

namespace ArrayManipulation.Tests
{
    [TestFixture]
    public class ArrayExtensionTests
    {
        [Test]
        public void FindBalanceIndex_ArrayIsNull_ThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => FindBalanceIndex(null));
        }

        [TestCase(new int[] { 1, 2, 5, 8, 0, 2, 4, 6, 4 }, ExpectedResult = 4)]
        [TestCase(new int[] { -32, 8, 1, 2, 4, 5, 12, -3, 0 }, ExpectedResult = 7)]
        [TestCase(new int[] { 2, 0, 5, 14, 3 }, ExpectedResult = null)]
        [TestCase(new int[] { }, ExpectedResult = null)]
        [TestCase(new int[] { 0, 0, 0, 0, 0, 0 }, ExpectedResult = 1)]
        [TestCase(new int[] { -1, 1, -1, 1, -1, 1, 32 }, ExpectedResult = null)]
        [TestCase(new int[] { 1 }, ExpectedResult = null)]
        public int? FindBalanceIndexTests(int[] array)
        {
            return FindBalanceIndex(array);
        }
    }
}