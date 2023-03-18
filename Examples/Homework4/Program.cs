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
System.Console.WriteLine(res2);
