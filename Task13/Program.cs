// 13. Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.
// Примеры:
// 645 -> 5 ; 78 -> третьей цифры нет; 32679 -> 6

Console.WriteLine("Введите любое число-> ");
string str = Console.ReadLine();

char[] arr = new char[str.Length];
for (int i = 0; i < str.Length; i++)
{
    arr[i] = str[i];
}

if (str.Length > 2) Console.WriteLine($"{str} -> {arr[2]}");
else Console.WriteLine($"{str} -> третьей цифры нет");


// Console.WriteLine("введите число: ");
// char [] array = Console.ReadLine().ToCharArray();
// var arrayValue = string.Join("", array);

// if (array.Length <=2) Console.WriteLine("Третьей цифры нет");
// else Console.WriteLine($"Третья цифра числа {arrayValue} = {array[2]}");
