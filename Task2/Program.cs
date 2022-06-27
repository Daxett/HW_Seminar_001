//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
// Числа вводятся в ручную 

Console.WriteLine ("ВВедите 2  любых целых числа ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a > b) 
{
    Console.WriteLine("max = {0}", a);
}
else
{
    Console.WriteLine("max = {0}", b);
}