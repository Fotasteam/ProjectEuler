int t = Convert.ToInt32(Console.ReadLine());
for (int a0 = 0; a0 < t; a0++)
{
    int n = Convert.ToInt32(Console.ReadLine());

    ulong a = 0;
    ulong b = 0;

    for (ulong i = 1; i <= (ulong)n; ++i)
    {
        a += i * i;
        b += i;
    }

    b *= b;

    Console.WriteLine(b - a);
}
