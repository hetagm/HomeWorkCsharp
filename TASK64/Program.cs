// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.



Console.Write("Введите N: "); 
int num = Convert.ToInt32(Console.ReadLine()); 
void ShowNums(int n)
{
    if (n > 1) ShowNums(n - 1);

    Console.Write(n + " ");
}

ShowNums(num);
Console.WriteLine();