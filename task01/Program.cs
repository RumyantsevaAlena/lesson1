// Напишите программу, которая на вход принимает два числа и 
//выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

System.Console.WriteLine("Введите первое число: ");
int num1st = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int num2nd = Convert.ToInt32(Console.ReadLine());

if (num1st >=num2nd)
{
    System.Console.WriteLine($"max:{num1st}");
}
else
 {
System.Console.WriteLine($"max:{num2nd}");
}