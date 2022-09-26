// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// ------ВАРИАНТ 1------ Четко по условию задачи!

void Polindrom(int num)
{
    int current = num;
    int result = 0;
    int i = 100000;
    while (num > 0)
    {
        int a = num % 10;
        num = num / 10;
        result = result + a * (i / 10);
        i = i / 10;
    }
    
    if(current == result)
        Console.WriteLine($"Число {current} - является палиндромом");
    else
        Console.WriteLine($"Число {current} - не является палиндромом");
}
Console.Write("Введите любое пятизначое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Polindrom(number);


// ------ВАРИАНТ 2------ Работает с любыми числами до 10 символов

/*void Polindrom(int num)
{
    string numberText = Convert.ToString(num);
    int length = numberText.Length;
    
    int current = num;
    int result = 0;
    int i = Convert.ToInt32(Math.Pow(10, length));
    
    while (num > 0)
    {
        int a = num % 10;
        num = num / 10;
        result = result + a * (i / 10);
        i = i / 10;
    }
        
    if(current == result)
        Console.WriteLine($"Число {current} - является палиндромом");
    else
        Console.WriteLine($"Число {current} - не является палиндромом");
}
Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Polindrom(number);*/


// ------ВАРИАНТ 3------ Работает с любыми числами

/*void Polindrom(long num)
{
    string numberText = Convert.ToString(num);
    long length = numberText.Length;
    
    long current = num;
    long result = 0;
    long i = Convert.ToInt64(Math.Pow(10, length));
    
    while (num > 0)
    {
        long a = num % 10;
        num = num / 10;
        result = result + a * (i / 10);
        i = i / 10;
    }
        
    if(current == result)
        Console.WriteLine($"Число {current} - является палиндромом");
    else
        Console.WriteLine($"Число {current} - не является палиндромом");
}
Console.Write("Введите любое число: ");
long number = Convert.ToInt64(Console.ReadLine());
Polindrom(number);*/
