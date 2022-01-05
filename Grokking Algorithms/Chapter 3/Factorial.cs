using System;

namespace Chapter_3
{
    public static class Factorial
    {
        public static int CalculateRecursively(int n)
        {
            if (n < 0)
            {
                throw new InvalidOperationException("you can't pass a negative value");
            }
            else if (n < 2)
            {
                return 1;
            }
            return n * CalculateRecursively(n - 1);
        }

        public static int CalculateItteratively(int n)
        {
            int result = 1;
            if (n < 0)
            {
                throw new InvalidOperationException("you can't pass a negative value");
            }
            else if (n < 2)
            {
                return 1;
            }
            while (n > 0)
            {
                result *= n;
                n--;
            }
            return result;
        }
    }
}
