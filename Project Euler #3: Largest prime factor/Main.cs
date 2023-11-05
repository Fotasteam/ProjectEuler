using System;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            long n = Convert.ToInt64(Console.ReadLine());
            
            Console.WriteLine(maxPrimeFactors(n)); //600851475143
        }
    }
    
    static long maxPrimeFactors(long n)
    {
        long maxPrime = -1;

        while (n % 2 == 0)
        {
            maxPrime = 2;
            n /= 2;
        }

        while (n % 3 == 0)
        {
            maxPrime = 3;
            n = n / 3;
        }

        for (int i = 5; i <= Math.Sqrt(n); i += 6)
        {
            while (n % i == 0)
            {
                maxPrime = i;
                n = n / i;
            }
            while (n % (i + 2) == 0)
            {
                maxPrime = i + 2;
                n = n / (i + 2);
            }
        }

        if (n > 4)
            maxPrime = n;

        return maxPrime;
    }
}
