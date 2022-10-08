// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int [,] CreateRandome2dArray()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимально возможное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимально возможное значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] newArray = new int[rows, colums];
    
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colums; j++)
            newArray[i,j] = new Random().Next(minValue,maxValue +1);
    
    return newArray;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] newArray = CreateRandome2dArray();
Show2dArray(newArray);
Console.Write("Введите индекс строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int colum = Convert.ToInt32(Console.ReadLine());
if (row > newArray.GetLength(0) || colum > newArray.GetLength(1))
    Console.WriteLine("Такого элемента нет");
else
    Console.WriteLine($"Значение элемента {row} строки и {colum} столбца равно {newArray[row,colum]}");
