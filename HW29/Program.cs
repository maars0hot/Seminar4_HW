// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 1, 33, 6]


int[] GenerateArray(int size,int MaxValue,int MinValue)
{
   int [] arr = new int[size];
   Random random = new Random();
   for (int i = 0; i < size; i++)
   {
    arr[i]=random.Next(MinValue,MaxValue+1);
   }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length -1; i++)
    {
        Console.Write($"{arr[i]},");
    }
Console.Write($"{arr[arr.Length-1]}]");
Console.WriteLine();
}


int[] array = GenerateArray(8,100,1);
PrintArray(array);