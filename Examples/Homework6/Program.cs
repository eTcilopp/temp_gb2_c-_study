// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] GetInitialDataFromUser()
{
    int[] resArray = new int[0];
    string nextElement = "";
    while (nextElement != "q")
    {
        System.Console.Write("Enter next number (`q` to finish); ");
        nextElement = Console.ReadLine()!;
        try
        {
            // Array.Resize(ref resArray, resArray.Length + 1);
            resArray[resArray.Length - 1] = Convert.ToInt32(nextElement);
        }
        catch
        {
            ;
        }
    }
    return resArray;
}

int getPositiveNumbersCount(int[] arr)
{
    int counter = 0;
    foreach(int el in  arr)
    {
        if (el > 0) counter++;
    }
    return counter;
}

int[] myArr = GetInitialDataFromUser();

int result = getPositiveNumbersCount(myArr);

System.Console.WriteLine(result);


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.


(decimal[], decimal[]) GetInitialData()
{
    decimal[] k = new decimal[3];
    decimal[] b = new decimal[3];

    for (int i=1; i<=2; i++)
    {
        System.Console.WriteLine($" Equation `y = k{i} * x + b{i}`");
        System.Console.Write($"Enter b{i}: ");
        b[i] = Convert.ToDecimal(Console.ReadLine())!;
        System.Console.Write($"Enter k{i}: ");
        k[i] = Convert.ToDecimal(Console.ReadLine())!;
        System.Console.WriteLine("--------------------");
    }

    return (b, k);
}


(decimal, decimal) SolveEquation(decimal[] b, decimal[] k)
{
    decimal x = (b[2]-b[1])/(k[1]-k[2]);
    decimal y = k[1] * x + b[1];
    return (x, y);
}

(decimal[] b, decimal[] k) = GetInitialData();
(decimal, decimal)res = SolveEquation(b, k);


System.Console.WriteLine($"X = {res.Item1}; Y = {res.Item2}");

