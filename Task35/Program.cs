// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.Write("Задайте размер массива -> ");
int size = int.Parse(Console.ReadLine());
//Console.WriteLine("Какое число необходимо найти?: ");
//int find = int.Parse(Console.ReadLine());
int[] array = new int[size];
var newRnd = new Random();
for (int i = 0; i < size; i++)
{
    array[i] = newRnd.Next(1, 200);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]>9 && array[i] <100)
     count++;
}
Console.WriteLine($"Кол-во элементов от 10 до 99 = {count}");
