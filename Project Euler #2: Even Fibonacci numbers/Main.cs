using System;
class Solution
{
    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            long n = Convert.ToInt64(Console.ReadLine());

            long fib0 = 0; long fib1 = 1;
            long sum = 0;

            while (fib1 <= n)
            {
                long c = fib1;
                fib1 += fib0;
                fib0 = c;

                if (fib1 % 2 == 0 && fib1 <= n)
                {
                    sum += fib1;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
