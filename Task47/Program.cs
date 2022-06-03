// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("введите кол-во строк массива: ");
int m = int.Parse (Console.ReadLine());
Console.WriteLine("введите кол-во столбцов массива: ");
int n = int.Parse (Console.ReadLine());

//метод заполнения двумерного массива типа double
double [,] GetArray(int a, int b)
{
    double[,] array = new double [a,b];
    Random rndNum = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rndNum.NextDouble()+rndNum.Next(-10,10);
                        
        }
        
    } 
    return array;
}
// вывод двумерного массива в консоль типа double
void PrintArray (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(array[i, j], 2)} ");
        }
        Console.WriteLine();
    }
}

double[,] arr = GetArray(m, n);
PrintArray(arr);

