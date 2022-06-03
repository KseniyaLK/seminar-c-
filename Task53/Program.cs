﻿// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.


// создание массива
int[,] GetArray(int a, int b)
{
    int[,] array = new int [a,b];
    Random rndNum = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rndNum.Next(0, 10);
        }
    } 
    return array;
}

// вывод массива на печать
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

int[,] arr = GetArray(5, 7);
PrintArray(arr);

int [,] GetArrayFlip(int [,] array)
{
    int a = array.GetLength(0);
    int b = array.GetLength(1);

    int[,] tempArray = new int [a, b];
    for (int i = 0; i < a; i++)
    {
        
        for (int j = 0; j < b; j++)
        {
            if(i == 0) tempArray [i, j] = array[a-1, j];
            else if (i == a-1) tempArray [i, j] = array[0, j];
            else tempArray[i, j] = GetArrayFlip [i, j];
        }
    }
    return tempArray;

}

int [,] arrFlip = GetArrayFlip(arr);
PrintArray(arr);
