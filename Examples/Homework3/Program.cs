// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

System.Console.Write("Enter 5-digit number :");
string five_digit_num = Console.ReadLine()!;

char[] charArray = five_digit_num.ToCharArray();
Array.Reverse(charArray);

if (new string(charArray) == five_digit_num)
{
    System.Console.WriteLine($"Palindrome");
}
else
{
    System.Console.WriteLine("Not a palindrome");
}

// Задача 19. Вариант 2

decimal five_digit_num_num = Convert.ToDecimal(five_digit_num);

int lastNumericalDigit = 1;
while (five_digit_num_num/lastNumericalDigit >= 1)
{
    lastNumericalDigit *= 10; 
}

int firstNumericalDigit = 1;
string res = "";
while (lastNumericalDigit >= 10)
{
    decimal nextDigit = Math.Floor(((decimal)five_digit_num_num % lastNumericalDigit) / (lastNumericalDigit /10)); //num%100//10
    decimal digitToCompare = Math.Floor((decimal)five_digit_num_num % (firstNumericalDigit * 10) / firstNumericalDigit); //num%100//10
    if (nextDigit != digitToCompare)
    {
        res = " not";
        break;
    }
    lastNumericalDigit /= 10;
    firstNumericalDigit *= 10;
}
System.Console.WriteLine($"This is{res} a palindrome");



//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


char[] arr = {'x', 'y', 'z'};
double sum = 0;
foreach (char axe in arr)
{
    double[] pos = new Double[3]; 
    for (int i=1; i <=2; i++)
    {
        System.Console.Write($"Enter coordinate {axe}{i}: ");
        pos[i] = Convert.ToInt32(Console.ReadLine())!;
    }
    sum += Math.Pow((pos[2] - pos[1]), 2);
}

System.Console.WriteLine($"Distance = {Math.Sqrt(sum)}");


// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

System.Console.Write("Enter N: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int n=1; n <= num; n++)
{
    System.Console.WriteLine(Math.Pow(n, 3));
}
