using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    public class DiagonalDifference
    {
        public static int Answer(int length, string[] matrix)
        {
            int leftDiagonal = 0;
            int rightDiagonal = 0;

            for (int i = 0; i < length; i++)
            {
                string[] matrixKeys = matrix[i].Split(' ');
                leftDiagonal += int.Parse(matrixKeys[i]);
                rightDiagonal += int.Parse(matrixKeys[length - i - 1]);
            }

            return Math.Abs(leftDiagonal - rightDiagonal);
        }
    }
}
