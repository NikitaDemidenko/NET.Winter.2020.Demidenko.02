using System;

namespace ArrayManipulation
{
    /// <summary>Provides methods for array extension.</summary>
    public static class ArrayExtension
    {
        /// <summary>Finds the maxIndex of the balance.</summary>
        /// <param name="array">An array.</param>
        /// <returns>Returns maxIndex or <em>null</em> if maxIndex not found.</returns>
        /// <exception cref="ArgumentNullException">Thrown when array is null.</exception>
        public static int? FindBalanceIndex(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            for (int i = 1; i < array.Length - 1; i++)
            {
                int leftPartSum = 0;
                int rightPartSum = 0;
                for (int j = i - 1; j >= 0; j--)
                {
                    leftPartSum += array[j];
                }

                for (int k = i + 1; k < array.Length; k++)
                {
                    rightPartSum += array[k];
                }

                if (leftPartSum == rightPartSum)
                {
                    return i;
                }
            }

            return null;
        }

        /// <summary>Finds the maximum item in the given array.</summary>
        /// <param name="array">An array.</param>
        /// <returns>Returns a value of maximum element.</returns>
        /// <exception cref="ArgumentNullException">Thrown when array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when array is empty.</exception>
        public static int FindMaximumItem(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length == 0)
            {
                throw new ArgumentException("Array cannot be empty.");
            }

            return MaximumItem(array, 0, array.Length - 1);
        }

        private static int MaximumItem(int[] array, int leftIndex, int rightIndex)
        {
            int middleIndex;
            middleIndex = (leftIndex + rightIndex) / 2;
            int leftPartMax;
            int rightPartMax;
            if (leftIndex == rightIndex)
            {
                return array[leftIndex];
            }

            leftPartMax = MaximumItem(array, leftIndex, middleIndex);
            rightPartMax = MaximumItem(array, middleIndex + 1, rightIndex);
            return leftPartMax > rightPartMax ? leftPartMax : rightPartMax;
        }
    }
}
