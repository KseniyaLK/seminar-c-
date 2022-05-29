//Задача16  Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

Console.Write("введите число, обозначающее день недели -> ");
var day = Convert.ToInt32(Console.ReadLine());
//string[] isWeekend = new string [7];
string[] isWeekend = { "no", "no", "no", "no", "no", "yes", "yes"};
if (day > 0 && day < 8)
{
    Console.WriteLine(isWeekend[day - 1]);
}
else Console.WriteLine("Вы ввели некорректное число");
