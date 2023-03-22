// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


int[] getRandomArray(int arraySize)
    {
        int[] resArray = new int[arraySize];
        Random random = new Random();
        for (int i=0; i<arraySize; i++)
        {
            resArray[i] = random.Next(100, 1000);
        }
        return resArray;
    }


int countEvenNumbers(int[] array)
{
    int evenNumberCount = 0;
    foreach(int element in array){
        if (element%2 == 0) evenNumberCount++;
    }
    return evenNumberCount;
}

Console.Write("Problem 1. Enter array size: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

int[] tergerArray = getRandomArray(arraySize);
Console.Write("[{0}]", string.Join(", ", tergerArray));
System.Console.WriteLine($"--> {countEvenNumbers(tergerArray)} even number(s).");

// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.




int sumOddIndexedElems(int[] array)
{
    int oddIndexedElemSum = 0;
    for (int idx=1; idx < array.Length; idx+=2)
    {
        oddIndexedElemSum +=  array[idx];
    }
    return oddIndexedElemSum;
}


Console.Write("Problem 2. Enter array size: ");
int array2Size = Convert.ToInt32(Console.ReadLine());
int[] oneDimentionalArr = getRandomArray(array2Size);

Console.Write("[{0}]", string.Join(", ", oneDimentionalArr));
System.Console.WriteLine($"--> {sumOddIndexedElems(oneDimentionalArr)}.");

// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
const int seed = 123;

double[] getArrayOfDoubles(Random randObj, int array3Size)
{
    double[] resArray = new double[array3Size];
    Random random = new Random();
    for (int i=0; i<array3Size; i++)
    {
        resArray[i] = randObj.NextDouble();
    }
    return resArray;
}


Random getRandomObj(int seed)
{
    Random fixRand = new Random(seed);
    return fixRand;
}


Console.Write("Problem 3. Enter array size: ");
int array3Size = Convert.ToInt32(Console.ReadLine());

double[] arrayOfDoubles = getArrayOfDoubles(getRandomObj(seed), array3Size);
Console.Write("[{0}]", string.Join(", ", arrayOfDoubles));

double getMinMaxDiff(double[] arrayOfDoubles)
{
    double min = arrayOfDoubles[0];
    double max = arrayOfDoubles[0];
    foreach(double el in arrayOfDoubles)
    {
        if (el > max) max = el;
        else if (el < min) min = el;
    }
    System.Console.WriteLine($"\nmin: {min}\nmax: {max}");
    return max - min;
}

System.Console.WriteLine($"diff: {getMinMaxDiff(arrayOfDoubles)}");
// System.Console.WriteLine(res[1]);