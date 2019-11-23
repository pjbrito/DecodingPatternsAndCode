using System;

namespace DecodingPatternsAndCode.Tests.Book.Chapter17
{
    public class AddWithoutPlus
    {
        public int IntAddImpl(int a, int b)
        {
            while (b != 0)
            {
                var v1 = Convert.ToString(a, toBase: 2);
                var v2 = Convert.ToString(b, toBase: 2);

                var sum = (a ^ b);
                var carry = (a & b) << 1;

                var tmp = a + b;

                a = sum;
                b = carry;
            }

            return a;
        }                                                                                                                                                                                                                                                                                                                                                                                                                                                                          
    }
}
