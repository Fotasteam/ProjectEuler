[ProjectEuler link](https://projecteuler.net/problem=1)
[Hackerrank link](https://www.hackerrank.com/contests/projecteuler/challenges/euler001/problem?isFullScreen=true)

# The Problem (Hackerrank version)

If we list all the natural numbers below **10** that are multiples of **3** or **5**, we get **3**, **5**, **6** and **9** . The sum of these multiples is **23**.

Find the sum of all the multiples of **3** or **5** below **N**.

***Input Format***

First line contains **T** that denotes the number of test cases. This is followed by **T** lines, each containing an integer, **N**.

***Constraints***

```math
1 \le T \le 10^5 \
1 \le N \le 10^9
```

***Output Format***

For each test case, print an integer that denotes the sum of all the multiples of  or  below .

***Sample Input 0***
```
2
10
100
```
***Sample Output 0***
```
23
2318
```
***Explanation 0***

For **N = 10**, if we list all the natural numbers below **10** that are multiples of **3** or **5**, we get **3**, **5**, **6** and **9**. The sum of these multiples is **23**.

Similarly for **N = 100**, we get **2318**.

# Solution

## Code (C#)

```csharp
long t = int.Parse(Console.ReadLine()), n, i = 0, sum3 = 0, sum5 = 0, sumboth = 0;

for (; i < t; ++i)
{
    n = int.Parse(Console.ReadLine());

    --n;
    sum3 = 3 * ((n / 3) * ((n / 3) + 1)) / 2;
    sum5 = 5 * ((n / 5) * ((n / 5) + 1)) / 2;
    sumboth = 15 * ((n / 15) * ((n / 15) + 1)) / 2;
    Console.WriteLine(sum3 + sum5 - sumboth);
}
```

## Explanation

This solution is way over-engineered, it can easily be answered using brute-force, however hackerranks constraints require a more complex solution.
For every n we calculate **sum3**, **sum5** and **sumboth** seperately. Why do we calculate the sum of both? We are going to subtract the instances, where the number is devisable by both **3** and **5**.
