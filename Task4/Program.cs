// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("Введите число N: ");
string number = Console.ReadLine();
int a = Convert.ToInt32(number);
int b = 0;
while (b < a - 1)
{
    System.Console.WriteLine($"{b+2}");
    b+=2;
}


    
