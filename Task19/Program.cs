// Задача 19: Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

// Console.Write("Введите пятизначное натуральное число -> ");
// string number = (Console.ReadLine());

// char[] num = number.ToCharArray();


// for (char i = 0; i <= num.Length-1; i++) 
// {
//      if (num[i] < 0)
//      num[i]= num[i]* -1;
// }
//if (num[i] < 0) number = number[1] * -1; //number[i] *= -1;



// if (number.Length < 5 || num.Length > 5) Console.WriteLine($"Введенное число {number} не соответствует заданным требованиям!");
// else if (num[0] == num[4] && num[1] == num[3]) Console.WriteLine($"Число {number} является полиндромом");
// else Console.WriteLine($"Число {number} не является полиндромом");


Console.WriteLine("введите 5-значное число: ");
char[] array = Console.ReadLine().ToArray();
var arrayValue = string.Join(" ", array);

if (array.Length > 4 && array.Length < 6)
{
    if (array[0] == array[4] && array[1] == array[3])
    {
        Console.WriteLine($"массив {arrayValue} является полидромом");
    }
    else 
    {
        Console.WriteLine($"массив {arrayValue} не является полидромом");
    }
}
else
{
    Console.WriteLine("массив состоит не из 5 чисел");
}

