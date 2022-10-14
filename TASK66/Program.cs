// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Конкретизируем. Напиcать программу, которая будет принимать на вход число и возвращать сумму его цифр, выводя пользователю.

int SumNumber(int m, int n)
{
    if(n > m) 
    {
        return SumNumber(m, n - 1) + n;
    }
    else return m;
}

Console.Write("Введите m: "); 
var num_m = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Введите n: "); 
var num_n = Convert.ToInt32(Console.ReadLine()); 

if (num_m > num_n)
{   int temp = num_m;
    num_m = num_n;
    num_n = temp;
    Console.Write($"Сумма натуральных элементов в промежутке от {num_n} до {num_m} - {SumNumber(num_m, num_n)}");
}
else
{
    if (num_m == num_n) Console.Write($"Введите число 'n' больше чем 'm', сейчас они равны");
    else Console.Write($"Сумма натуральных элементов в промежутке от {num_m} до {num_n} - {SumNumber(num_m, num_n)}");
}

