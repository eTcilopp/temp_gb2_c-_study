// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

System.Console.Write("Enter 5-digit number :");
string five_digit_num = Console.ReadLine()!;

char[] charArray = five_digit_num.ToCharArray();
Array.Reverse(charArray);

if (new string(charArray) == five_digit_num)
{
    System.Console.WriteLine($"palindrome");
}
else
{
    System.Console.WriteLine("not palindrome");
}

//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// int x1 = int.Parse(Console.ReadLine())!;
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());


double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)  + Math.Pow((z2 - z1), 2));


System.Console.WriteLine(distance);

// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

System.Console.Write("Enter N :");
int num = Convert.ToInt32(Console.ReadLine());

for (int n=1; n <= num; n++)
{
    System.Console.WriteLine(Math.Pow(n, 3));
}
