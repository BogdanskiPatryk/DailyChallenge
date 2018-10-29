using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge17
    {
        public int[] ProceedOld(int[] input, int k)
        {
            if (k <= 0 || k > input.Length)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (k == 1)
            {
                return input;
            }
            if (k == input.Length)
            {
                return new int[] { input.Max() };
            }
            int[] result = new int[input.Length - k + 1];
            for (int i = 0; i <= input.Length - k; ++i)
            {
                result[i] = input.Skip(i).Take(k).Max();
            }
            return result;
        }

        public int[] Proceed(int[] input, int k)
        {
            if (k <= 0 || k > input.Length)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (k == 1)
            {
                return input;
            }
            if (k == input.Length)
            {
                return new int[] { input.Max() };
            }
            int[] result = new int[input.Length - k + 1];
            for (int i = k - 2; i >= 0; --i)
            {
                input[i] = Math.Max(input[i], input[i+1]);
                
            }
            result[0] = input[0];
            for(int i = 1; i <= input.Length - k; ++i)
            {
                int last = i + k -1;
                input[i + k - 2] = Math.Max(input[last-1], input[last]);
                if (input[i + k - 2] >= input[i])
                {
                    result[i] = input[i + k - 2];
                    for(int j = i+1; j < i + k - 2;++j)
                    {
                        input[j] = result[i];
                    }
                }
                else
                {
                    result[i] = input[i];
                    input[i + 1] = Math.Max(input[i + 1], input[i + k - 2]);
                }
            }
            return result;
        }
    }
}
