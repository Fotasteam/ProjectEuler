# Problem #8: Largest product in a series

[ProjectEuler link](https://projecteuler.net/problem=8)
[Hackerrank link](https://www.hackerrank.com/contests/projecteuler/challenges/euler008/problem?isFullScreen=true)

# The Problem (Hackerrank version)

Find the greatest product of **K** consecutive digits in the **N** digit number.

***Input Format***

First line contains **T** that denotes the number of test cases.
First line of each test case will contain two integers **N** & **K**.
Second line of each test case will contain a **N** digit integer.

***Constraints***

```math
1 \le T \le 100 <br />
```

```math
1 \le K \le 7 <br />
```

```math
K \le N \le 1000
```

***Output Format***

Print the required answer for each test case.

***Sample Input 0***
```
2
10 5
3675356291
10 5
2709360626
```
***Sample Output 0***
```
3150
0
```
***Explanation 0***

- For **3675356291** and selecting **K=5** consequetive digits, we have **36753**, **67535**, **75356**, **53562**, **35629** and **56291**. Where **6 x 7 x 5 x 3 x 5** gives maximum product as **3150**
- For **2709360626**, **0** lies in all selection of **5** consequetive digits hence maximum product remains **0**

# Solution (Original problem)

## Code (C#)

```csharp
string number = 
    "73167176531330624919225119674426574742355349194934" +
    "96983520312774506326239578318016984801869478851843" +
    "85861560789112949495459501737958331952853208805511" +
    "12540698747158523863050715693290963295227443043557" +
    "66896648950445244523161731856403098711121722383113" +
    "62229893423380308135336276614282806444486645238749" +
    "30358907296290491560440772390713810515859307960866" +
    "70172427121883998797908792274921901699720888093776" +
    "65727333001053367881220235421809751254540594752243" +
    "52584907711670556013604839586446706324415722155397" +
    "53697817977846174064955149290862569321978468622482" +
    "83972241375657056057490261407972968652414535100474" +
    "82166370484403199890008895243450658541227588666881" +
    "16427171479924442928230863465674813919123162824586" +
    "17866458359124566529476545682848912883142607690042" +
    "24219022671055626321111109370544217506941658960408" +
    "07198403850962455444362981230987879927244284909188" +
    "84580156166097919133875499200524063689912560717606" +
    "05886116467109405077541002256983155200055935729725" +
    "71636269561882670428252483600823257530420752963450";

List<long> ListOfProducts = new List<long>();

for (int i = 0; i < 988; ++i)
    ListOfProducts.Add(IloczynLiczby(number[i].ToString() + number[i+1].ToString() + number[i + 2].ToString()
 + number[i + 3].ToString() + number[i + 4].ToString() + number[i + 5].ToString() + number[i + 6].ToString()
 + number[i + 7].ToString() + number[i + 8].ToString() + number[i + 9].ToString() + number[i + 10].ToString()
 + number[i + 11].ToString() + number[i + 12].ToString()));

ListOfProducts.Sort();
Console.WriteLine(ListOfProducts[ListOfProducts.Count-1]);

long IloczynLiczby(string liczba)
{
    return long.Parse(liczba[0].ToString())
        * long.Parse(liczba[1].ToString())
        * long.Parse(liczba[2].ToString())
        * long.Parse(liczba[3].ToString())
        * long.Parse(liczba[4].ToString())
        * long.Parse(liczba[5].ToString())
        * long.Parse(liczba[6].ToString())
        * long.Parse(liczba[7].ToString())
        * long.Parse(liczba[8].ToString())
        * long.Parse(liczba[9].ToString())
        * long.Parse(liczba[10].ToString())
        * long.Parse(liczba[11].ToString())
        * long.Parse(liczba[12].ToString());
}
```

## Explanation

Another simple problem, we brute force it. We save every possible set of **13-sequence** numbers to **ListOfProducts**. Afterwards, we calculate the product in **IloczynLiczby**. Finally, sort the list to get it chronogically and print the last entry.

# Solution (Hackerrank)

## Code (C#)

```csharp
int t = Convert.ToInt32(Console.ReadLine());
for (int a0 = 0; a0 < t; a0++)
{
    string[] tokens_n = Console.ReadLine().Split(' ');
    int n = Convert.ToInt32(tokens_n[0]);
    int k = Convert.ToInt32(tokens_n[1]);
    string num = Console.ReadLine();

    List<long> ListOfProducts = new List<long>();
            
    for (int i = 0; i < num.Length - k + 1; ++i) {
        string sequence = "";
        
        for (int j = 0; j < k; ++j)
            sequence += num[i + j].ToString();
        
        ListOfProducts.Add(IloczynLiczby(sequence, k));
    }
    
    ListOfProducts.Sort();
    Console.WriteLine(ListOfProducts[ListOfProducts.Count-1]);
}

long IloczynLiczby(string liczba, int k)
{
    long number = 1;
    
    for (int i = 0; i < k; ++i) 
        number *= long.Parse(liczba[i].ToString());
    
    return number;
}
```

## Explanation

Another simple problem, we brute force it. For every **n-digit** number we save every possible set of **k-sequence** numbers to **ListOfProducts**. Afterwards, we calculate the product in **IloczynLiczby**. Finally, sort the list to get it chronogically and print the last entry.
