// Задача 38: Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());

double[] array = new double[size];

var newRnd = new Random();
for (int i = 0; i < size; i++)
{
    array[i] = newRnd.Next(-100, 999);
    Console.Write(array[i] + " "); //вывод массива в терминал
}
Console.WriteLine();

double min = array[1];
double max = array[1];
double rez = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
    if (array[i] > max)
    {
        max = array[i];
    }
    rez = max - min;
}
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {rez}");












//double max = array[i];



