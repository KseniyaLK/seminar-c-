// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.

/// Создание случайного двумерного массива
int[,] GetArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random arrayRandomValue = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = arrayRandomValue.Next(1, 10);
        }
    }
    return array;
}

/// Метод печати массива
void PrintArray(int[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}


int[,] arr = GetArray(3, 3);
PrintArray(arr);



void ArithmeticMean(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        double sum = 0;
        double result = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        result = sum / array.GetLength(1);
        Console.Write($"{Math.Round(result, 1)}   ");
    }
}

ArithmeticMean(arr);
Console.WriteLine(ArithmeticMean);
