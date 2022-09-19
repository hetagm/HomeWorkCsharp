// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру дня недели (1-7): ");
int num = Convert.ToInt32(Console.ReadLine());

void DayOfTheWeek(int number)
{
    if (number > 5)
        Console.WriteLine($"Данный день {number} - выходной");
    else
        Console.WriteLine($"Данный день {number} - является рабочим");
}

DayOfTheWeek(num);
