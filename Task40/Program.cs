// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.



bool run = true;
while (run)
{
    Console.Clear();
    Console.WriteLine("Задайте первую сторону треугольника");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Задайте вторую сторону треугольника");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine("Задайте третью сторону треугольника");
    int c = int.Parse(Console.ReadLine());
    Console.WriteLine(a < b + c && b < a + c && c < b + a ? "Может" : "Не может");
    Console.WriteLine("Попробуем ещё раз? y/n");
    run = Console.ReadKey().Key == ConsoleKey.Y;
}

