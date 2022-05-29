// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// bool run = true;
// while (run)
// {
//     Console.Clear();
//     Console.WriteLine("Введите число");
//     int num = int.Parse(Console.ReadLine());

//     int digit = 0; //остаток от деления
//     int rezult = 1; // накопитель
//     for (int i = 0; i < num; i++)
//     {
//         digit = num%2;
//         rezult = rezult *10 +digit;
//         num = num/2;
//     }

//     Console.WriteLine(rezult);
//     Console.WriteLine("Попробуем ещё раз? y/n");
//     run = Console.ReadKey().Key == ConsoleKey.Y;
// }



Console.Write("введите число: ");
int num = int.Parse(Console.ReadLine());

Console.Write("введите основание системы счисления: ");
int baseNum = int.Parse(Console.ReadLine());

// int result = 0;
// int d10 = 1;
// while (num != 0)
// {
//     result = result + num % baseNum * d10;
//     num /= baseNum; // num = num/2
//     d10 *= 10; // d10=d10*10
// }

// Console.WriteLine(result);

void DecToOther (int n, int baseN )
{
    if(n == 0) return;
    DecToOther(n / baseN, baseN);
    
    Console.Write(n % baseN);
}

DecToOther(num, baseNum);
