// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.


int[,] GetArray(int a, int b)
{
    int[,] array = new int [a,b];
    Random rndNum = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rndNum.Next(0, 10);
            if(i%2 ==0 && j%2 ==0)
            {
                array[i,j] = array[i,j]*array[i,j];
            }
        }
    } 
    return array;
}

int[,] ChangeArray(int[,] array)
{
    int[,] array = new int [a,b];
    Random rndNum = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rndNum.Next(0, 10);
            if(i%2 ==0 && j%2 ==0)
            {
                array[i,j] = array[i,j]*array[i,j];
            }
        }
    } 
    return array;
}


void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

// int[,] ChangeArray(int a, int b)
// {
//     int[,] array = new int [a,b];
//     Random rndNum = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rndNum.Next(0, 10);
//         }
//     } 
//     return array;
// }


int[,] arr = GetArray(5, 7);
PrintArray(arr);
ChangeArray(int a, int b)
PrintArray(arr);