// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.

Console.WriteLine("Введите число A:");
int numA=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int numB=Convert.ToInt32(Console.ReadLine());
int A = StepNumber (numA,numB);
Console.WriteLine(A);
int StepNumber (int A,int B)
{
    for (int i = 1; i <= B; i++)
    {
        A = A*i;
    }
    return A;
}