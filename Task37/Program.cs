// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// Console.WriteLine("Введите размер массива: ");
// int len = int.Parse(Console.ReadLine());

// int[] array = new int [len];
// var newRnd = new Random();

// for (int i = 0; i < array.Length; i++)
// {
//     array [i] = newRnd.Next(1,11);
//     Console.Write(array[i] + " ");
// }
// int coll = 1;
// int [] coll = new int [array.Length/2];
// for (int i = 0; i < array.Length; i++)
// {
//         if (i == array[array.Length-1-i]) coll[i] = array[i];
//         coll[i] = array[i] * array[array.Length-1-i];
//         Console.Write(coll[i] + " ");
// }


Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());

int[] num = new int [size];



var newRnd = new Random();
for (int i = 0; i < size; i++)
{
    num[i] = newRnd.Next(-10, 10);
    Console.Write(num[i] + " ");
}
Console.WriteLine();

int[] rez = new int [num.Length/2];

for (int i = 0; i < rez.Length; i++)
{
    rez[i] = num[i]+num[num.Length-1-i];
    Console.Write(rez[i] + " ");
}
if (size%2 == 1) Console.WriteLine(num[num.Length/2]); // нужно добить вывод в середину массива!!!
Console.WriteLine();
//if (size%2 == 1) Console.WriteLine(num[num.Length/2]);
