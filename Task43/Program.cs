// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 *
// x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 =
// 9 -> (-0,5; 5,5)

Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());






// Console.WriteLine("Какое колличество чисел Вы хотите ввести?");
// int quantityNumber = int.Parse(Console.ReadLine());
// int [] array = new int [quantityNumber];

// /// Метод заполнения массива значениями пользователя
// int FillArrayUserNumbers (int number)
// {
//     for (int i = 0; i < number; i++)
//     {
//         Console.WriteLine($"Введите {i + 1} число:");
//         array[i] = int.Parse(Console.ReadLine());
//     }
//     return number;
// }

// FillArrayUserNumbers (quantityNumber);

double x = 0;
double y = 0;
double IntersectionLines (double b1, double k1, double b2, double k2)
{
    
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    return (x);
    return (y);
    
}
double result = IntersectionLines (b1, k1, b2, k2);
Console.WriteLine($"Точка пересечения двух прямых ({x}; {y})");

//Console.WriteLine($"Точка пересечения двух прямых ({IntersectionLines(b1, k1, b2, k2)})");

