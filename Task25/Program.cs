// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A -> ");
int num = int.Parse(Console.ReadLine());
Console.Write("Введите число B -> ");
int degree = int.Parse(Console.ReadLine());

int DegreeOfNumber(int num, int degree)
{
    int result = 1;
    for (int count = 0; count < degree; count++)
    {
        result = result * num;
    }
    return result;
}

int Itog = DegreeOfNumber(num, degree);
Console.WriteLine($"Число {num} возводимое в степень числа {degree} = {Itog}");
