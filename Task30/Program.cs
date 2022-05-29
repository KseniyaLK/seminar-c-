//  30. Напишите программу, которая выводит массив из 8 элементов, 
//  заполненный нулями и единицами в случайном порядке. 
//  [1,0,1,1,0,1,0,0]

int[] array = new int[8];
void FillArray(int[] array)
{
int length = array.Length;
int i = 0;
while (i < length)
{
    array[i] = new Random().Next(0, 2);
    i++;


}
}

Console.Write("[");

void PrintArray(int [] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
}




FillArray(array);
PrintArray(array);
Console.Write("]");


// int[] array = new int[8];
// void FillArray(int[] array)
// {
//     int length = array.Length;
//     int i = 0;
//     while (i < length)
//     {
//         array[i] = new Random().Next(0, 2);
//         Console.Write($"{array[i]}, ");
//         i++;

//     }
// }

// FillArray(array);