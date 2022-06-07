// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


Console.WriteLine("Введите число M");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());

NaturalNumber(n, m);
Console.ReadKey();

// void NaturalNumber(int numM, int numN)
// {
//     if (numN == numM) return;
//     NaturalNumber(numN-1, numM);
//     Console.Write(numN);
// }
void NaturalNumber(int n, int m)
{
    if (n == m)
    {
        Console.WriteLine(n);
        return;
    }
    if (m < n)
    {
        NaturalNumber(n - 1, m);
        Console.WriteLine(n);
    }
    else
    {
        NaturalNumber(n + 1, m);
        Console.WriteLine(n);
    }
}


// if (m > n)
//     {
//         num = m;
//         if (num == n) return;
//         NaturalNumbers(num - 1);
//         System.Console.Write($"{num} ");
//     }
//     else if (n > m)
//     {
//         num = n;
//         if (num == n) return;
//         NaturalNumbers(num - 1);
//         System.Console.Write($"{num} ");
//     }
//     else Console.WriteLine("Вы ввели равные числа");

