void NextFib(int limit, int prev1 = 0, int prev2 = 1)
{
    int new_val = 0;
    int counter = 0;
    while (counter <= limit)
    {
        new_val = prev1 + prev2;
        Console.WriteLine(new_val);
        NextFib(limit, prev2, new_val);
        counter++;
    }
}

NextFib(10);