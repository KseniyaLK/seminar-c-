// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());

int[] array = new int[size];


var newRnd = new Random();
for (int i = 0; i < size; i++)
{
    array[i] = newRnd.Next(100, 999);
    Console.Write(array[i] + " "); //вывод массива в терминал
}
Console.WriteLine();

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count = count + 1;
    }
}

Console.WriteLine($"Кол-во четных чисел в массиве = {count}");





