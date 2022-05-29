//11. Напишите программу, которая выводит случайное трехзначное число 
//и удаляет вторую цифру этого числа
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Number = {number}");

int number1 = number/100;
//Console.WriteLine(number1);

int number2 = number%10;
// while (number / p > 9) p *= 100;
// int y = number % p;
//Console.WriteLine(number2);
Console.WriteLine($"Результат задачи {number1}{number2}");
