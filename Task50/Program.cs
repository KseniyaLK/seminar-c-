// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
            Console.Write("{0,6}", array[i, j]);
        }
        Console.WriteLine();
    }
}


int[,] arr = GetArray(5, 7);
PrintArray(arr);



Console.WriteLine("Введите позицию строки: ");
int numberRow = int.Parse(Console.ReadLine());

Console.WriteLine("Введите позицию столбца: ");
int numberColumn = int.Parse(Console.ReadLine());


void ExaminationIndex(int[,] array, int a, int b)
{
    if (a > array.GetLength(0)-1 || b >array.GetLength(1)-1)
    {
           Console.WriteLine("Такого элемента нет в заданном массиве"); 
    }
    else Console.WriteLine($"Элемент с позицией {a}, {b} = {array[a, b]}");
   
}


ExaminationIndex(arr, numberRow, numberColumn);
Console.WriteLine(ExaminationIndex);



