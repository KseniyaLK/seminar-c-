// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Number = {number}");
int maxNum = MaxNumber (number);
// int firstDigit = number / 10;
// int secondDigit = number % 10;
// Console.WriteLine($"Number1 = {firstDigit}");
// Console.WriteLine($"Number2 = {secondDigit}");
//Console.WriteLine(firstDigit > secondDigit ? $"Max = {firstDigit}" : $"Max = {secondDigit}");
//  if(firstDigit > secondDigit) Console.WriteLine($"Max = {firstDigit}");
//  else Console.WriteLine($"Max = {secondDigit}");
Console.WriteLine($"Max = {maxNum}");


int MaxNumber (int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

