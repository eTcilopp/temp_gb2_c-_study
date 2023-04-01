// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


int[] SortDesc(int[] array)
{
    bool changed=false;
    for (int i=0; i<array.Length-1; i++)
    {
        if (array[i+1] > array[i])
        {
            int temp = array[i];
            array[i] = array[i+1];
            array[i+1] = temp;
            changed = true;
        }
    }
    if (changed==false) return array;
    return SortDesc(array);
}

int[,] GetSortedArray(int[,] unsortedArray)
{
    int[,] resArray = new int[unsortedArray.GetLength(0), unsortedArray.GetLength(1)];
    for (int i=0; i<unsortedArray.GetLength(0); i++)
    {
        int[] subArray = new int[unsortedArray.GetLength(1)];
        for (int j=0; j<unsortedArray.GetLength(1); j++)
        {
            subArray[j] = unsortedArray[i, j];
        }
        subArray = SortDesc(subArray);
        for (int j=0; j<unsortedArray.GetLength(1); j++)
        {
            resArray[i, j] = subArray[j];
        }
    }
    return resArray;
}

void print2dArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
       for (int j=0; j<array.GetLength(1); j++)
       {
        Console.Write($"{array[i, j]} ");
       }
       Console.WriteLine();
    } 
}


int[,] myArray = new int [,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

print2dArray(myArray);
System.Console.WriteLine();
print2dArray(GetSortedArray(myArray));
