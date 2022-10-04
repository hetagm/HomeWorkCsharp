// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void FindPoint(double a, double c, double b, double d)
{
    double x = (d-c) / (a-b);
    double y = a * x + c;
    if(a == b)
        Console.Write("Прямые параллельны");
    else
        Console.Write($"Точка пересечения двух прямых: x: {x}, y: {y}");
}

Console.Write("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

FindPoint(k1, b1, k2, b2);