// 66. Показать натуральные числа от 1 до N, N задано
void ShowNaturalNumbers(int N)
{
    if (N >= 1)
    {
        ShowNaturalNumbers(N - 1);
        System.Console.Write($"{N} ");
    }
}

// 67. Показать натуральные числа от N до 1, N задано
void BackwardsShowNaturalNumbers(int i, int N)
{
    System.Console.Write($"{N} ");
    N--;
    if (i <= N) BackwardsShowNaturalNumbers(i, N);
}

// 68. Показать натуральные числа от M до N, N и M заданы
void ShowNaturalNumbersBetween(int M, int N)
{
    System.Console.Write($"{M} ");
    M++;
    if (M <= N) ShowNaturalNumbersBetween(M, N);
}

// 69. Найти сумму элементов от M до N, N и M заданы
int SummOfElements(int M, int N, int sum)
{
    if (M <= N)
    {
        sum = M + SummOfElements(M + 1, N, sum);
    }
    return sum;
}

// 70. Найти сумму цифр числа
int SummOfDigits(int N, int sum)
{
    string str = Convert.ToString(N);
    int L = str.Length;
    if (L != 0)
    {
        char symbol = str[0];
        int numb = Convert.ToInt32(Convert.ToString(symbol));
        sum = sum + numb;
        string str2 = string.Empty;
        for (int i = 1; i < str.Length; i++)
        {
            str2 = str2 + str[i];
        }
        if (str2.Length != 0)
        {
            N = Convert.ToInt32(str2);
            sum = SummOfDigits(N, sum);
        }
    }
    return sum;
}

// 71. Написать программу вычисления функции Аккермана
int AkkermanFunction(int m, int n, int sum)
{
    if (m == 0) { sum = sum + n + 1; }
    if (m > 0 && n == 0) { sum = AkkermanFunction(m - 1, 1, sum); }
    if (m > 0 && n > 0) { sum = AkkermanFunction(m - 1, AkkermanFunction(m, n - 1, sum), sum); }
    return sum;
}

// 72. Написать программу возведения числа А в целую стень B
int ToPower(int N, int M, int number)
{
    number = number * N;
    M--;
    if (M > 0)
    {
        number = ToPower(N, M, number);
    }
    return number;
}

//73. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем
void FibanacciRow(int A, int B, int N)
{
    System.Console.Write($"{A} ");
    int C = B + A;
    A = B;
    N--;
    if (N > 0)
    {
        FibanacciRow(A, C, N);
    }
}

// 74. В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
// Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита
void FourLetterDictionary(int N, string word)
{
    if (N > 0)
    {
        word = word;
        FourLetterDictionary(N - 1, word + "а");
        FourLetterDictionary(N - 1, word + "и");
        FourLetterDictionary(N - 1, word + "с");
        FourLetterDictionary(N - 1, word + "в");
    }
    else
    {
        System.Console.WriteLine(word);
    }
}

// ShowNaturalNumbers(9);
// System.Console.WriteLine();
// BackwardsShowNaturalNumbers(1, 9);
// System.Console.WriteLine();
// ShowNaturalNumbersBetween(6, 12);
// System.Console.WriteLine();
// int sum = SummOfElements(8, 10, 0);
// System.Console.WriteLine(sum);
// System.Console.WriteLine();
// int sumD = SummOfDigits(2311, 0);
// System.Console.WriteLine(sumD);
// int Akk = AkkermanFunction(3, 8, 0);
// System.Console.WriteLine(Akk);
// System.Console.WriteLine();
// int resultOfPow = ToPower(5, 3, 1);
// System.Console.WriteLine(resultOfPow);
// System.Console.WriteLine();
// FibanacciRow(1,3,7);
System.Console.WriteLine();
FourLetterDictionary(4,"");