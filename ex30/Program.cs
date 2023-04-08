int[]Array = new int[15];
FillArray(Array);
PrintArray(Array);


void FillArray(int [] userArray)
{
    for (int i = 0; i < userArray.Length; i++)
    {
        userArray[i] = new Random().Next(0,10);

    }
}

void PrintArray(int [] userArray)
{
    Console.Write("|");
    for (int i = 0; i < userArray.Length; i++)
    {
        if(i==userArray.Length-1)
        {
        Console.Write($"{userArray[i]}");
        }
        else Console.Write($"{userArray[i]},");
    }
    Console.Write("|");
    Console.WriteLine();
}