List<ulong> Numbers = new List<ulong>();
List<ulong> PrimeNumbers = new List<ulong>();

int t = Convert.ToInt32(Console.ReadLine());
for (int a0 = 0; a0 < t; a0++)
    Numbers.Add(ulong.Parse(Console.ReadLine()));

ulong iPrime = 0;
ulong i = 2;

for (; iPrime <= Numbers.Max(); ++i)
    if (isPrime(i))
    {
        ++iPrime;
        PrimeNumbers.Add(i);
    } 

for (int j = 0; j < Numbers.Count; ++j)
    Console.WriteLine(PrimeNumbers[(int)Numbers[j]-1]);

bool isPrime(ulong number)
{
    for (ulong i = 2; i < number; ++i)
        if (number % i == 0)
            return false;

    return true;
}
