using System;

namespace PadawansTask3
{
    public static class IntegerExtensions
    {
        public static int Gcd(int a, int b)
        {
            while ((a != 0) && (b != 0))
            {
                if (a > b)
                    a -= b;
                else
                {

                    b -= a;
                }
            }

            return Math.Max(a, b);

            throw new ArgumentNullException();
            throw new ArgumentException();
            throw new NotImplementedException();
        }

        static void Main()
        {
            var result = Gcd(9, 1);
            Console.WriteLine(result);
        }
    }
}
