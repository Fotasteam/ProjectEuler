int t = Convert.ToInt32(Console.ReadLine());
for (int a0 = 0; a0 < t; a0++)
{
    int n = Convert.ToInt32(Console.ReadLine());

    int i = 1;
    while (!IsNumberEvenlyDivisable(i))
        ++i;

    Console.WriteLine(i);

    bool IsNumberEvenlyDivisable(int currentNumber)
    {
        for (int i = 2; i <= n; ++i)
            if (currentNumber % i != 0) return false;

        return true;
    }
}
