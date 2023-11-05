using System;
class Solution {

    static void Main(String[] args) {
        long t = int.Parse(Console.ReadLine()), n, i = 0, sum3 = 0, sum5 = 0, sumboth = 0;

        for (; i < t; ++i)
        {
            n = int.Parse(Console.ReadLine());

            --n;
            sum3 = 3 * ((n / 3) * ((n / 3) + 1)) / 2;
            sum5 = 5 * ((n / 5) * ((n / 5) + 1)) / 2;
            sumboth = 15 * ((n / 15) * ((n / 15) + 1)) / 2;
            Console.WriteLine(sum3+sum5-sumboth);
        }
    }
}
