using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge43
    {
        /*
         * We can determine how "out of order" an array A is by counting the number of inversions it has. Two elements A[i] and A[j] form an inversion if A[i] > A[j] but i < j. That is, a smaller element appears after a larger element.
Given an array, count the number of inversions it has. Do this faster than O(N^2) time.
You may assume each element in the array is distinct.
For example, a sorted list has zero inversions. The array [2, 4, 1, 3, 5] has three inversions: (2, 1), (4, 1), and (4, 3). The array [5, 4, 3, 2, 1] has ten inversions: every distinct pair forms an inversion.
         */

        public int Proceed(int[] array)
        {
            return ProceedIntern(array, new int[array.Length], 0, array.Length - 1);
        }

        private int ProceedIntern(int[] input, int[] temp, int left, int right)
        {
            if (right <= left)
            {
                return 0;
            }
            int mid = (right + left) / 2;
            int inversions = ProceedIntern(input, temp, left, mid);
            inversions += ProceedIntern(input, temp, mid +1, right);
            inversions += ProceedIntern(input, temp, left, mid + 1, right);
            return inversions;
        }

        private int ProceedIntern(int[] input, int[] temp, int left, int mid, int right)
        {
            int onLeft = left;
            int onRight = mid;
            int mergedIndex = left;
            int inversions = 0;
            while ((onLeft <= mid - 1) && (onRight <= right))
            {
                if (input[onLeft] <= input[onRight])
                {
                    temp[mergedIndex++] = input[onLeft++];
                }
                else
                {
                    temp[mergedIndex++] = input[onRight++];
                    inversions += (mid - onLeft);
                }
            }

            while (onLeft <= mid - 1)
            {
                temp[mergedIndex++] = input[onLeft++];
            }

            while (onRight <= right)
            {
                temp[mergedIndex++] = input[onRight++];
            }

            for (onLeft = left; onLeft <= right; onLeft++)
            {
                input[onLeft] = temp[onLeft];
            }

            return inversions;
        }

    }
}
