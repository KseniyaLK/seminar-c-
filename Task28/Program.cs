//  Напишите программу, которая принимает на вход число N
//   и выдаёт произведение чисел от 1 до N. 
//   4 -> 24 5 -> 120

Console.WriteLine("Введите число ->");
int n = int.Parse(Console.ReadLine());

int GetComNumbers(int number)
{
    int composition = 1;
    for (int i = 1; i <= number; i++)
    {
        composition = composition * i;
    }
    
    return composition;
}



int ComResult = GetComNumbers (n);

Console.WriteLine($"Произведение чисел от 1 до {n} равна {ComResult}");

