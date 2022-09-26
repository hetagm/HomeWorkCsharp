// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void FindCube(int num)
{
    int i = 1;
    Console.Write($"Таблица кубов чисел от 1 до {num} - ");
    while(i <= num)
    {
        if(i == num) 
            Console.Write($"{i*i*i}.");
        else
            Console.Write($"{i*i*i}, ");

        i++;
    }
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

FindCube(number);