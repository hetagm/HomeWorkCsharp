// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void SumOfNumbers(int num)
{
    int n = num;
    int sum = 0;
    
    while(num > 0)
    {
        sum = sum + num % 10;
        num /= 10;
    }
    Console.WriteLine($"Сумма цифр числа {n} = {sum}");
    
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
SumOfNumbers(number);
