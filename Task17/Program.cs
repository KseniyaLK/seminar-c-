//Задача17. Напишите программу, которая на вход принимает координаты точки
// x и y (причем x И Y не равны 0) и выдвет номер четверти, в которой находится эта точка



Console.WriteLine("Введите координату X -> "); 
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Y -> "); 
int y = int.Parse(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Номер четверти -> 1");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Номер четверти -> 2");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Номер четверти -> 3");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Номер четверти -> 4");
}
