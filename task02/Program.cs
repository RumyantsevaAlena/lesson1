// Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

System.Console.WriteLine("Введите первое число: ");
int num1st = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int num2nd = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье число: ");
int num3rd = Convert.ToInt32(Console.ReadLine());

int max = num1st;

if (num1st > max) max = num1st;

if (num2nd > max) max = num2nd;

if (num3rd > max) max = num3rd;
System.Console.Write("max: ");
System.Console.WriteLine(max);