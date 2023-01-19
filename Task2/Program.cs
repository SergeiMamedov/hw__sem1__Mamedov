// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("Введите первое число: ");
string number = Console.ReadLine() ?? "";
int a = Convert.ToInt32(number);
System.Console.WriteLine("Введите второе число: ");
string number1 = Console.ReadLine() ?? "";
int b = Convert.ToInt32(number1);
System.Console.WriteLine("Введите третье число: ");
string number2 = Console.ReadLine() ?? "";
int c = Convert.ToInt32(number2);
if (a > b && a > c)
{
    System.Console.WriteLine($"число {a} больше числа {b} и больше числа {c}");
} 
if (b > a && b > c)
{
    System.Console.WriteLine($"число {b} больше числа {a} и больше числа {c}");
}
else System.Console.WriteLine($"число {c} больше числа {a} и больше числа {b}");