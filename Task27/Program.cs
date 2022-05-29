// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число -> ");
int num = int.Parse(Console.ReadLine());
if (num < 0) num = num * -1;

int SumNumbers(int number)
{
    int sum = 0;
    while (number != 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return (sum);
}
// int result = SumNumbers (num);
// Console.WriteLine($"Сумма цифр в числе {num} = {result}");
Console.WriteLine($"Сумма цифр в числе {num} = {SumNumbers(num)}");