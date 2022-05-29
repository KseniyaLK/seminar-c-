// 3. написать программу, которая на вход принимает число
//  и выдает является ли число четным

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 2 == 0) 
{
    Console.WriteLine("Введенное число - четное!");
}
else 
{
    Console.WriteLine("Введенное число - не четное!");
}

 
 //bool result = n % 2 == 0;
 //Console.WriteLine(result ? "число четное" : "число не четное");
