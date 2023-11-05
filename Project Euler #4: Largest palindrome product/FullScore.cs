List<int> reliablePossiblePalindromes = new List<int>();

for (int left = 100; left < 1000; ++left)
{
    if (left % 11 == 0)
        for (int right = 100; right < 1000; right++)
            reliablePossiblePalindromes.Add(left * right);
}

int t = Convert.ToInt32(Console.ReadLine());
for (int a0 = 0; a0 < t; a0++)
{
    int n = Convert.ToInt32(Console.ReadLine());

    int largestPalindrome = 0;

    foreach (int possiblePalindrome in reliablePossiblePalindromes)
        if (isNumberAPalindrome(possiblePalindrome.ToString(), n) && possiblePalindrome > largestPalindrome)
            largestPalindrome = possiblePalindrome;

    Console.WriteLine(largestPalindrome);
}

bool isNumberAPalindrome(string num, int MaxValue)
{
    if (num.Length == 6 && num[0] == num[5] && num[1] == num[4] && num[2] == num[3] && int.Parse(num) < MaxValue)
        return true;

    return false;

}
