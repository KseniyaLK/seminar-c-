// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число");
int b = int.Parse(Console.ReadLine());


NaturalNumber(n);
Console.ReadKey();

void NaturalNumber(int num)
{
    if (num == 0) return;
    NaturalNumber(num-1);
    Console.Write(num + " ");
}