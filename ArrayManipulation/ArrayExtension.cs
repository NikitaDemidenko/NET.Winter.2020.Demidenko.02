using System;

namespace ArrayManipulation
{
    /// <summary>Provides methods for array extension.</summary>
    public static class ArrayExtension
    {
        /// <summary>Finds the index of the balance.</summary>
        /// <param name="array">An array.</param>
        /// <returns>Returns index or <em>null</em> if index not found.</returns>
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
    }
}
