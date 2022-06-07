// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());

NaturalNumber(n);
Console.ReadKey();

int sum = 0;
void NaturalNumber(int num)
{
    if (num == 0) return;
    NaturalNumber(num/10);
   
    sum = sum + num % 10; 
    Console.WriteLine($"{sum} ");
    
}


// int sum = 0;
// int NaturalNumbers(int num)
// {
//     sum = sum + (num % 10);
//     if (num == 0) return sum;
//     NaturalNumbers(num / 10);
//     Console.Write($"{sum} ");
//     return sum;
    
// }
// NaturalNumbers(n);

