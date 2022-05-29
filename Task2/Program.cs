//2. написать программу, которая ан вход принимает три числа, 
// а на выход выдает максимальное из этих трех

Console.Write("Введите первое число: ");
int n1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int n2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int n3 = int.Parse(Console.ReadLine());
int max = n1;
if (n2 > n1) max = n2;
if (max > n2) max = n3;
Console.WriteLine("Максимальное число = "+max);
