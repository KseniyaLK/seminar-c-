// Задача 29: Напишите программу, которая задаёт массив целых чисел и выводит их на экран.
// Размер массива определяется пользователем.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Задайте разер массива: ");
int size = int.Parse (Console.ReadLine());
// Console.WriteLine("Введите элементы массива через пробел: ");
// int [] numArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
// Console.WriteLine(string.Join(' ', numArray));


int [] array = new int [size];

 void FillArray (int [] array)
 {
     for (int i = 0; i < array.Length; i++)
     {
         array[i] = new Random().Next(1, 99);
     }
 }

 void PrintArray (int [] array)
 {
     for (int i = 0; i < array.Length; i++)
     {
         Console.Write(array[i] +"\t");
     }
 }
 

FillArray(array);
PrintArray(array);
Console.WriteLine(" ");

