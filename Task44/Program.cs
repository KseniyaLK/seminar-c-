// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
// Fn = Fn-1 + Fn-2

//     Console.Clear();
//     Console.WriteLine("Введите число");
//     int n = int.Parse(Console.ReadLine());
//      int pervoe = 0; 
//     int vtoroe = 1;
//     int sum = 0;
    
     
//    while ( n >= sum)
//    {
//        sum = pervoe + vtoroe;
//        Console.Write($"0, {sum}");
//        pervoe = vtoroe;
//        vtoroe = sum
//    }

//    Console.WriteLine(" ");


   int pervoe = 0 ;
   int vtoroe = 1 ;
   Console.Write("введите кол-во чисел Фибо: ");
   int n = int.Parse(Console.ReadLine());
   Console.Write(pervoe + " " + vtoroe + " ");
   int sum = 0;
   for (int i = 0; i <= n; i++)
   {
       sum = pervoe + vtoroe;
       Console.Write(sum + " ");
       pervoe = vtoroe;
       vtoroe = sum;
   }
