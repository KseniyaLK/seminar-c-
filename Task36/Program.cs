// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19 
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива: ");
int size = int.Parse (Console.ReadLine());

int[] array = new int[size];

var newRnd = new Random();

for (int i = 0; i < size; i++)
{
    array[i] = newRnd.Next(-100, 100);
    Console.Write(array[i] + " "); //вывод массива в терминал
}
Console.WriteLine();

int sum =0;
for (int i = 0; i < array.Length; i++)
{
    if (i%2 !=0)
    {
        sum = sum + array[i];
    }
}
Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях = {sum}");
