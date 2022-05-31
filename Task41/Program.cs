// Задача 41. Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите целые числа через пробел: ");
int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

int PositivElements(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count = count + 1;
        }

    }
    return count;
}

int SumResult = PositivElements(array);

Console.WriteLine($"В массиве [ {String.Join(' ', array)} ] содержится {SumResult} чисел больше нуля");




