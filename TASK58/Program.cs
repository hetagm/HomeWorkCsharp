// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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
int[,] MultiplicationMatrix(int[,] array, int[,] array1)
{
    int rows = array1.GetLength(0);
    int colums = array.GetLength(1);
    int[,] newArray = new int[rows, colums];
    if(rows != colums) Console.WriteLine("Данные матрицы умножать нельзя!");
    else
        
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < colums; j++)
            {
                int sum = 0;
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    sum += array[i,k] * array1[k,j];
                }
                newArray[i,j] = sum;
            }
        }
        return newArray;
}
Console.WriteLine("Заполнение первой матрицы: ");
int[,] newArray1 = CreateRandome2dArray();
Console.WriteLine("\nЗаполнение второй матрицы: ");
int[,] newArray2 = CreateRandome2dArray();
Show2dArray(newArray1);
Show2dArray(newArray2);
Console.WriteLine("\nРезультат умножения двух матриц: ");
int[,] newArray3 = MultiplicationMatrix(newArray1, newArray2);
Show2dArray(newArray3);