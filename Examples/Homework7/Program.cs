// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

(int, int) GetInitialData(string msg1, string msg2)
{
    System.Console.Write($"{msg1}: ");
    int m = Convert.ToInt32(Console.ReadLine())!;
    System.Console.Write($"{msg2}: ");
    int n = Convert.ToInt32(Console.ReadLine())!;
    return (m, n);
}


double[,] CreateRandomMatrix(int rows, int cols)
{
    double[,] matrix = new double[rows, cols];
    Random randObj = new Random();
    for (int row=0; row<matrix.GetLength(0); row++)
    {
        for (int col=0; col<matrix.GetLength(1); col++)
        {
            matrix[row, col] = randObj.NextDouble();
            System.Console.Write(matrix[row, col]);
        }
        System.Console.WriteLine();
    }
    return matrix;
}

(int m, int n) = GetInitialData("Enter number of ROWS", "Enter number of COLS");
double[,] filledMatrix = CreateRandomMatrix(m, n);

// Задача 50. Напишите программу, которая на вход принимает два числа(строка, столбец), 
// проверяя есть ли такая позиция в двумерном массиве и возвращает сообщение о том,
//что оно найдено, а также какое число стоит на этом месте или же указание, что такого элемента нет.


// Используем массив из предыдущей задачи.

(int row, int col) = GetInitialData("Enter ROW number", "Enter COLUMN number");

try
{
    System.Console.WriteLine($"Element {row}:{col} exists and is equal to {filledMatrix[row, col]}");
}
catch
{
    System.Console.WriteLine($"Element {row}:{col} is out of scope");
}

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] GetMatrixOfRandomIntegers(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    Random randObj = new Random();
    for (int row=0; row<matrix.GetLength(0); row++)
    {
        for (int col=0; col<matrix.GetLength(1); col++) 
        {
            matrix[row, col] = randObj.Next(0, 100);
            System.Console.Write($"{matrix[row, col]}, ");
        }
        System.Console.WriteLine();
    }
    return matrix;
}

double[] GetColumnAvg(int[,] matrix)
{   double[] res = new double[matrix.GetLength(1)];
    double colAvg = 0;
    for (int col=0; col<matrix.GetLength(1); col++)
    {
        colAvg = 0;
        for (int row=0; row<matrix.GetLength(0); row++) 
        {
            colAvg += matrix[row, col];
        }
        colAvg = colAvg / matrix.GetLength(0);
        res[col] = colAvg;
    }
    return res;
}



(int r, int c) = GetInitialData("Enter number of ROWS", "Enter number of COLS");
int[,] intMatrix = GetMatrixOfRandomIntegers(r, c);
Console.WriteLine("--------------");
double[] arrOfAvg = GetColumnAvg(intMatrix);

foreach(double el in arrOfAvg)
{
    Console.Write($"{el}, ");
}



