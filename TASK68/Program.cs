// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите m: "); 
var num_m = Convert.ToDouble(Console.ReadLine()); 

Console.Write("Введите n: "); 
var num_n = Convert.ToDouble(Console.ReadLine()); 

double FuncAkkerman(double m, double n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return FuncAkkerman(m - 1, 1);
    }
    else
    {
        return (FuncAkkerman(m - 1, FuncAkkerman(m, n - 1)));
    }
}

Console.Write($"{FuncAkkerman(num_m, num_n)}");