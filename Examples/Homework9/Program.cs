//Задача 64: Выполнить с помощью рекурсии.Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 

void GetSequenceRec(int n)
{
    if (n == 1)
    {
        Console.WriteLine(n);
        return;
    }
    Console.Write($"{n}, ");
    GetSequenceRec(n-1);
}


GetSequenceRec(8); //8, 7, 6, 5, 4, 3, 2, 1

//Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int GetSum(int num1, int num2, int sum=0)
{
    if (num1==num2) return sum+num1;
    else if (num1>num2) return sum; 
    return GetSum(num1+1, num2-1, sum+num1+num2);
}


System.Console.WriteLine(GetSum(1,15)); //120

//Задача 68: Выполнить с помощью рекурсии.Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Ackermann(int m, int n)
{
    if (m==0) return n + 1;
    else if (n==0) return Ackermann(m-1, 1);
    return Ackermann(m-1, Ackermann(m, n-1));
}

Console.WriteLine(Ackermann(0,0)); // 1
Console.WriteLine(Ackermann(1,1)); // 3
Console.WriteLine(Ackermann(2,2)); // 7
Console.WriteLine(Ackermann(3,5)); // 253
