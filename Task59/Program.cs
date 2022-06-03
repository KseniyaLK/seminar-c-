// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7


// создание массива
// int[,] GetArray(int a, int b)
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

// // вывод массива на печать
// void PrintArray (int[,] array)

// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

//PrintArray(array); 
// Console.WriteLine();
// int [,] GetArrayCate(int [,] array)
// {
//     int a = array.GetLength(0);
//     int b = array.GetLength(1);
//     int[,] tempArray = new int [a-1, b-1];
//     int min = array [0,0];
//     int minPosi = 0;
//     int minPosj = 0;
//     for (int i = 0; i < a; i++)
//     {
        
//         for (int j = 0; j < b; j++)
//         {
//             if (array [i, j] < min)
//             min = array[i,j];
//             minPosi = i;
//             minPosj = j;
           
//         }
//     }
    
//       for (int i = 0; i < a; i++)
//     {
        
//         for (int j = 0; j < b; j++)
//         {
//             if (i != minPosi || j != minPosj)
//             {
//             tempArray[i,j] = array [i,j];
//             }
//             else if (i = minPosi)
//             {
//                 tempArray[i,j] = array [i+1,j];
//             }
//             else if (j == minPosj)
//             {
//                 tempArray[i,j] = array [i,j+1];
//             }
//         }
//     }
    

//     Console.WriteLine($"(min) i = {minPosi} j = {minPosj}");
//     return tempArray;

// }

// int [,] arrCute =GetArrayCate(array);
// PrintArray(arrCute);

int[,] GetArray(int a, int b)
{
	int[,] array = new int[a, b];
	Random rndNum = new Random();
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = rndNum.Next(10);
		}
	}
	return array;
}

void PrintArray(int[,] array)
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

int [,] Min(int[,] array)
{
	int min = 0;
    int indexI = 0;
    int indexJ = 0;
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			
			if (min > array[i, j])
			{
				min = array[i, j];
                indexI = i;
                indexJ = j;
			}
        }
    }
    return new int [] {indexI, indexJ, min};
}

int [,] ResultMatrix (matrix, int [] idxs)
{
    int flagI = 0;
    int flagJ = 0;
    int [,] newMatrix = new int [matrix.GetLength(0)-1, matrix.GetLength(1)-1];
    for (int i = 0; i < matrix.GetLength(0)-1; i++)
    {
        for (int j = 0; j < matrix.GetLength(1)-1; j++)
        {
            if (i >= idxs[0]) {flagI = 1;}
            else {flagI = 0;}
            if (j >= idxs[1]) {flagJ = 1;}
            else {flagJ = 0;}

            newMatrix[i, j] = matrix[i + flagI, j + flagJ];

        }
    }
    return newMatrix;

}

int [,] matrix = GetArray (5, 5);
PrintArray(matrix);
Console.WriteLine();
int [] indexes = Min(matrix);
Console.WriteLine($"Min = {indexes[2]}");
int [,] resultArray = ResultMatrix (matrix, indexes, indexes);
PrintArray(resultArray);


