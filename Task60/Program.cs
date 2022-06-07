// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

// создание массива
int[, ,] GetArray(int a, int b, int c)
{
    int[, ,] array = new int[a, b, c];
    Random rndNum = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {               

            array[i, j, k] = rndNum.Next(10, 100);
            }
        }
    }
    return array;
}

// вывод массива на печать
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
            Console.Write($"{array[i, j, k]} инд {i},{j},{k}   ");
            }
            Console.WriteLine();
        }
        //Console.WriteLine();
    }
}

int[, ,] arr = GetArray(5, 5, 5);
PrintArray(arr);
Console.WriteLine();
