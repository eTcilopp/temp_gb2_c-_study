//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int power(int num_a, int num_b)
{
    if (num_b > 1)
    {
        return num_a * power(num_a, num_b-1);
    }
    else
    {
        return num_a;
    }
}

int res = power(3, 7); //2187
System.Console.WriteLine("Problem 25, var. 1");
System.Console.WriteLine(res);

// Вариант 2

int power_(int num1, int num2)
{
    int res2 = 1;
    for (int i=1; i <= num2; i++)
    {
        res2 *= num1;
    }
    return res2;
}
int res2 = power_(3, 7); //2187
System.Console.WriteLine("Problem 25, var. 2");
System.Console.WriteLine(res2);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int getNumberSum(int num)
{
    int sum = 0;
    while(num > 0)
    {
        sum += num%10;
        num /= 10;
    }
    return sum;
}

System.Console.WriteLine("Problem 27");
System.Console.WriteLine(getNumberSum(9012)); //12
System.Console.WriteLine(getNumberSum(452)); //11
System.Console.WriteLine(getNumberSum(82)); //11

// Задача 29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)

int[] getArray(int arraySize)
    {
        int[] resArray = new int[arraySize];
        Random random = new Random();
        for (int i=0; i<arraySize; i++)
        {
            resArray[i] = random.Next(0, 100);
        }
        return resArray;
    }

System.Console.WriteLine("Problem 29");
foreach (int number in getArray(10))
{
    System.Console.WriteLine($"Array el: {number}");
}

