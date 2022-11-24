//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. */
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3


double a, b;
Console.WriteLine("Введите первое число: ");
a = Double.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
b = Double.Parse(Console.ReadLine());

if(a>b)
    Console.WriteLine("{0} - max, {1} - min", a, b);
else
    Console.WriteLine("{0} - max, {1} - min", b, a);
