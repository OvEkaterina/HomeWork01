﻿//Задача 2: Напишите программу, которая на вход принимает
// два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.Clear();
Console.WriteLine("Введите первое число :");
int number1 = int.Parse (Console.ReadLine());
Console.WriteLine("Введите второе число :");
int number2 = int.Parse (Console.ReadLine());
  if (number2 > number1)
    { 
        Console.WriteLine($"max = {number2}");
        Console.WriteLine($"min = {number1}");
    } 
    else
    {
        Console.WriteLine($"max = {number1}");
        Console.WriteLine($"min = {number2}");
    }
