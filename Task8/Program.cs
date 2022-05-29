//  8. Напишите программу, которая принимает на вход два числа и проверяет,
//  является ли одно число квадратом другого. 
//  5, 25  ->  да-4, 16  ->  да 25, 5  ->  да 12 мин 8,9  ->  нет

Console.WriteLine("введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());

int res = num1 * num1;
if (res == num2) Console.WriteLine($"{num2} является квадратом {num1}");
else Console.WriteLine($"{num2} не является квадратом {num1}");

// Console.Write("Enter number A :");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Enter number B :");
// int b = int.Parse(Console.ReadLine());
// bool res = b == a * a || a == b * b;
// Console.WriteLine(res ? "Да" : "Нет");

// Console.WriteLine("ввидите певое число ->");
// int number1 = int.Parse(Console.ReadLine());
// Console.WriteLine("ввидите второе число ->");
// int number2 = int.Parse(Console.ReadLine());
//  if(number1 * number1 == number2)
// Console.WriteLine("Да является!");
// else 
// Console.WriteLine("Нет");

