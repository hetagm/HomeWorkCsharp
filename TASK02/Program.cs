﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
// Решил в двух вариантах(Оба варианта работают)

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 > number2)
{
    Console.WriteLine($"Число {number1} больше числа {number2}");
}
else
{
    Console.WriteLine($"Число {number1} меньше числа {number2}");
}


// Console.WriteLine("Введите первое число:  ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число:  ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if (number1 > number2) 
// {
//     Console.WriteLine("ПЕРВОЕ число со значением " +  number1  + " БОЛЬШЕ!");
//     Console.WriteLine("Второе число со значением " +  number2  + " меньше!");
// }
// else
// {
//     Console.WriteLine("ВТОРОЕ число со значением " + number2 + " БОЛЬШЕ");
//     Console.WriteLine("Первое число со значением " + number1 + " меньше");
// }

