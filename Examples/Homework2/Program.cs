// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("-------------");
Console.WriteLine("Enter Three-digit Number: ");
string three_digit_num = Console.ReadLine();
if (three_digit_num.Length != 3)
{
    Console.WriteLine(three_digit_num + " is not a three-digit number");
}
else
{
   Console.WriteLine(three_digit_num[1]); 
}


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("-------------");
Console.WriteLine("Enter Number: ");
string num = Console.ReadLine();

try
{
    Console.WriteLine(num[2]);
}
catch
{   
    Console.WriteLine("No 'third' digit in " + num);
}


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("-------------");
Console.WriteLine("Enter Day Number: ");
string day_num = Console.ReadLine();
int[] weekend_days = {6, 7};
if (weekend_days.Contains(Convert.ToInt32(day_num)))
{
    Console.WriteLine("Day " + day_num + "is a WeekEnd");
}
else
{
    Console.WriteLine("Day " + day_num + " is NOT a WeekEnd");
}
