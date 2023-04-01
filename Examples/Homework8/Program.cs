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

void Print2dArray(int[,] array)
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

Print2dArray(myArray);
System.Console.WriteLine();
Print2dArray(GetSortedArray(myArray));

//Задача 57: Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.



void PrintArrayFA(int[,] array)
{
    Dictionary<int, int> dict = new Dictionary<int, int>();
    foreach(int el in array)
    {
        try
        {
            dict.Add(el, 1);
        }
        catch
        {
            dict[el]++; 
        }
    }

    foreach (KeyValuePair<int, int> kvp in dict)
    {
        Console.WriteLine($"{kvp.Key}: found {kvp.Value} time(s);");
    }
}


int[,] myArray2 = new int [,]
{
    {1, 2, 3},
    {4, 6, 1},
    {2, 1, 6}
};

Print2dArray(myArray2);
PrintArrayFA(myArray2);


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 

bool CoordFreeAndExists((int, int) coords, int[,] realm)
{
    try
    { 
        if (realm[coords.Item1, coords.Item2] == 0) return true;
        return false;
    }
    catch
    {
        return false;
    }
}


int[,] realm = new int[4, 4];

MovingObject walker = new MovingObject((0,0), "right");

int i = 0;
while (true)
{
    i++;
    realm[walker.currentCoords.Item1, walker.currentCoords.Item2] = i;
    if (CoordFreeAndExists(walker.GetNextCoord(), realm)) walker.MakeStep();
    else
    {
        walker.ChangeDirection();
        if (!CoordFreeAndExists(walker.GetNextCoord(), realm)) break;
        walker.MakeStep();
    }

}

Print2dArray(realm);



class MovingObject
{
    public (int,int) currentCoords;
    public string direction;

    public MovingObject((int,int) currentCoords, string direction)
    {
        this.currentCoords = currentCoords;
        this.direction = direction;
    }

    public void ChangeDirection()

    {
        if (this.direction == "right") this.direction = "down";
        else if (this.direction == "down") this.direction = "left";
        else if (this.direction == "left") this.direction = "up";
        else this.direction = "right";
    }

    public (int, int) GetNextCoord()
    {
        if (this.direction=="right") return (currentCoords.Item1, currentCoords.Item2 + 1);
        if (this.direction=="down") return (currentCoords.Item1+1, currentCoords.Item2);
        if (this.direction=="left") return (currentCoords.Item1, currentCoords.Item2 - 1);
        return (currentCoords.Item1-1, currentCoords.Item2);
    }

    public void MakeStep()
    {   
        this.currentCoords = this.GetNextCoord();
    }
}


