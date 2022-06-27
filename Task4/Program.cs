// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// чиста вводятся в ручную

Console.WriteLine ("ВВедите 3  любых целых числа ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if (a > b)
    if (a > c)
        Console.WriteLine("max = {0}", a);
    else
        Console.WriteLine("max = {0}", c);
else
    if (b > c)
        Console.WriteLine("max = {0}", b);
    else
        Console.WriteLine("max = {0}", c);