//1. написать программу, которая на вход принимает два числа, 
// а на вывод выдает какое из них большее, какое меньшее 

Console.Write("Введите первое число: ");
int n1 = int.Parse (Console.ReadLine ());
Console.Write("Введите второе число: ");
int n2 = int.Parse (Console.ReadLine ());
if (n1 > n2)
{
    Console.WriteLine("Максимальное число = "+n1);
    Console.WriteLine("Минимальное число = "+n2);

}
else 
{
    Console.WriteLine("Максимальное число = "+n2); 
    Console.WriteLine("Минимальное число = "+n1); 
}
    