using System;

namespace MatrixManipulations
{
    /// <summary>
    /// Matrix manipulation.
    /// </summary>
    public static class MatrixExtension
    {
        /// <summary>
        /// Method fills the matrix with natural numbers, starting from 1 in the top-left corner,
        /// increasing in an inward, clockwise spiral order.
        /// </summary>
        /// <param name="size">Matrix order.</param>
        /// <returns>Filled matrix.</returns>
        /// <exception cref="ArgumentException">Throw ArgumentException, if matrix order less or equal zero.</exception>
        /// <example> N = 3
        ///     1 2 3
        ///     8 9 4
        ///     7 6 5.
        /// </example>
        /// <example> N = 4
        ///     1  2  3  4
        ///     12 13 14 5
        ///     11 16 15 6
        ///     10 9  8  7.
        /// </example>
        public static int[,] GetMatrix(int size)
        {
            if (size < 1)
            {
                throw new ArgumentException("Size cannot be less or equals zero.", nameof(size));
            }

            var matrix = new int[size, size];
            int count = size;
            bool isHorizontallyDirection = true;
            bool isHorizontallyRightDirection = true;
            bool isVerticallyDownDirection = true;
            int currentValue = 1;
            int horizontalPosition = -1;
            int verticalPosition = 0;

            while (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (isHorizontallyDirection)
                    {
                        horizontalPosition = isHorizontallyRightDirection ? horizontalPosition + 1 : horizontalPosition - 1;
                    }
                    else
                    {
                        verticalPosition = isVerticallyDownDirection ? verticalPosition + 1 : verticalPosition - 1;
                    }

                    matrix[verticalPosition, horizontalPosition] = currentValue;
                    currentValue++;
                }

                isHorizontallyDirection = !isHorizontallyDirection;

                if (!isHorizontallyDirection)
                {
                    isHorizontallyRightDirection = !isHorizontallyRightDirection;
                    count--;
                }
                else
                {
                    isVerticallyDownDirection = !isVerticallyDownDirection;
                }
            }

            return matrix;
        }
    }
}
