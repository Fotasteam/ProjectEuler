int t = Convert.ToInt32(Console.ReadLine());
for (int a0 = 0; a0 < t; a0++)
{
    int n = Convert.ToInt32(Console.ReadLine());

    int largestPalindrome = 0;

    for (int left = 100; left < 1000; ++left)
    {
        for (int right = 100; right < 1000; right++)
        {
            int number = left * right;
            if (isNumberAPalindrome(number.ToString(), n) && number > largestPalindrome)
                largestPalindrome = number;
        }
    }

    Console.WriteLine(largestPalindrome);
}

bool isNumberAPalindrome(string num, int MaxValue)
{
    string leftSequence = "";
    string rightSequence = "";
    for (int i = 0; i < num.Length; ++i)
    {
        if (i < num.Length / 2)
            leftSequence += num[i];
        else
            rightSequence += num[i];
    }

    rightSequence = rightSequence[2].ToString() + rightSequence[1].ToString() + rightSequence[0].ToString();

    if (num.Length % 2 == 0 && leftSequence == rightSequence && int.Parse(leftSequence + rightSequence) < MaxValue)
        return true;

    return false;
}
