// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.Write("Задайте размер массива -> ");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("Какое число необходимо найти?: ");
int find = int.Parse(Console.ReadLine());
int[] array = new int[size];
var newRnd = new Random();
string result = "нет";
for (int i = 0; i < size; i++)
{
    array[i] = newRnd.Next(-9,10);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

for (int i = 0; i < size; i++)
{
    if (array[i] == find) result = "да";
}
Console.WriteLine(result);

