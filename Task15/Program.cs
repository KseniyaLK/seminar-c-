﻿//15. Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// Примеры:
// 6 -> да; 7 -> да; 1 -> нет

Console.WriteLine("Введите цифру, соответсвующую дню недели -> ");
int n = int.Parse(Console.ReadLine());
if (n == 6 || n == 7) Console.WriteLine ($"{n} -> да");
else if (n<1 || n >7) Console.WriteLine ("Вы ввели ошибочную цифру");
else Console.WriteLine ($"{n} -> нет");
