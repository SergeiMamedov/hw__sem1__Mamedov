﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.WriteLine("Введите первое число: ");
string number = Console.ReadLine() ?? "";
int a = Convert.ToInt32(number);
System.Console.WriteLine("Введите второе число: ");
string number1 = Console.ReadLine() ?? "";
int b = Convert.ToInt32(number1);
if (a > b)
{
    System.Console.WriteLine($"число {a} больше числа {b}");
}
else System.Console.WriteLine($"число {b} больше числа {a}");