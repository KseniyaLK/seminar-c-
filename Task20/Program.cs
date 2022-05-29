// 20.Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 2D пространстве.
//   A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21



Console.WriteLine("Введите координату первой точки X -> "); 
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату первой точки Y -> "); 
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату второй точки X -> "); 
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату второй точки Y -> "); 
double y2 = Convert.ToDouble(Console.ReadLine());
//double sum = (x1-x2)*(x1-x2) + (y1-y2)*(y1-y2);
//double result = Math.Sqrt (sum);
double result = Math.Sqrt ((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2));
// result=Math.Round(result, 2);

// Console.WriteLine($"{result}");

Console.WriteLine($"{result:F}");