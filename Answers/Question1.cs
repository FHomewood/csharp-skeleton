using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question1
    {
        public static int Answer(int[] portfolios)
        {
            //just a quick brute force method
            int bestVal = 0;
            int[] bestCombo = new int[15];
            int[] A = new int[15];
            int[] B = new int[15];
            for (int i = 0; i < portfolios.Length-1;i++)
            {
                for (int j = portfolios.Length-1; j > 0; j++)
                {
                    int[] p1 = ToPortfolio(portfolios[i]);
                    int[] p2 = ToPortfolio(portfolios[j]);
                    int[] Combo = Combine(p1, p2);
                    int Value = ToValue(Combo);
                        if (Value > bestVal)
                        {
                            bestVal = Value;
                            B = p2;
                            A = p1;
                        }
                }
            }
            return bestVal;

            int ToValue(int[] a)
            {
                double output = 0;
                for (int k = 0; k < a.Length; k++) output += a[k] * Math.Pow(2, k);
                return (int)output;
            }
            int[] ToPortfolio(int a)
            {
                int[] output = new int[15];
                for (int k = output.Length - 1; k >= 0; k--)
                {
                    int pow = (int)Math.Pow(2, k);
                    output[k] = (a % pow == 1) ? 1 : 0;
                    a -= pow * output[15];

                }
                return output;
            }
            int[] Combine(int[] a, int[] b)
            {
                int[] c = new int[15];
                for (int k = 0; k < 15; k++)
                {
                    c[k] = a[k] ^ b[k];
                }
                return c;
            }
        }
    }
}
