// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
Console.Write("Enter first number:");
int first_number = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number:");
int second_number = Convert.ToInt32(Console.ReadLine());

if (first_number > second_number)
{
    Console.WriteLine("Число " + first_number + " больше, чем число " + second_number);
}
else if (first_number < second_number)
{
    Console.WriteLine("Число " + first_number + " меньше, чем число " + second_number);
}
else
{
    Console.WriteLine("Число " + first_number + " равно числу " + second_number);
}

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");

Console.Write("Enter first number :");
int first_number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number :");
int second_number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third number :");
int third_number2 = Convert.ToInt32(Console.ReadLine());

int max = first_number2;
if (second_number2 > max)
{
    max = second_number2;
}
if (third_number2 > max)
{
    max = third_number2;
}

Console.WriteLine("Max = " + max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка(number%2==0)).
Console.WriteLine("Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка(number%2==0)).");

Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("Четное");
}
else
{
    Console.Write("Нечетное");
}

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
Console.Write("Enter number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= number2; i++)
{
    if (i%2 == 0)
    {
        Console.Write(i + " ");
    }
}
