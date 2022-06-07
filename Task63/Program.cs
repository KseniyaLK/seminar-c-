//задача63
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());

NaturalNumber(n);
Console.ReadKey();

void NaturalNumber(int num)
{
    if (num == 0) return;
    NaturalNumber(num-1);
    Console.Write(num + " ");
}

