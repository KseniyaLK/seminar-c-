// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


Console.Write("Введите натуральное число -> ");
int num = int.Parse(Console.ReadLine());

int GetSumNumbers(int number)
// void GetSumNumbers(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum = sum + i;
    }
    //Console.WriteLine($"Сумма чисел от 1 до {num} равна {sum}");
    return sum;
}

// // int sum = 0;
// // for (int i = 1; i <= num; i++)
// // {
// //     sum = sum + i;
// // }

int SumResult = GetSumNumbers(num);
//GetSumNumbers(num);
Console.WriteLine($"Сумма чисел от 1 до {num} равна {SumResult}");

//Console.WriteLine($"Сумма чисел от 1 до {num} равна {sum}");


