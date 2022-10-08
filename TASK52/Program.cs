// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void SumElementsEachColumn(int[,] array)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        int n = array.GetLength(1);
        double average = 0;
        for(int i = 0; i < array.GetLength(0); i++)
        {
            average += array[i,j];
        }

        average /= n;
        Console.WriteLine($"Среднее арифметическое по {j} столбцу:  {average};");
        //Console.Write(average + "; ");
    }

    Console.WriteLine();
}

int[,] newArray = CreateRandome2dArray();
Show2dArray(newArray);
SumElementsEachColumn(newArray);