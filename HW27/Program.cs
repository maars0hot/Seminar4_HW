﻿// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int sum = SumNumbers(number);
Console.WriteLine($"Сумма цифр в числе {number} = {sum}");

int SumNumbers (int num)
{
    int sum = 0;
    while (num >0)
    {
        sum = sum + num %10;
        num = num /10;
    }
    return sum;
}

