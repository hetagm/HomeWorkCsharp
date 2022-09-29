// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

void FindLevel(int num1, int num2)
{
    int res = 1;
    for(int current = 1; current <= num2; current++)
        res = res * num1;
    
    Console.WriteLine($"Число {num1} в натуральной степени {num2} = {res}");
}
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
FindLevel(number1, number2);
