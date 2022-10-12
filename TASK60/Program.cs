// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int [,,] CreateRandome3dArray()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите количество столбцов: ");
    int colums = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите количество колонок: ");
    int colums1 = Convert.ToInt32(Console.ReadLine());

    int[,,] newArray = new int[rows, colums, colums1];
    
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colums; j++)
            for(int k = 0; k < colums1; k++)
                newArray[i,j,k] = GenerateUniqueNumber();
    
    return newArray;
}

void Show3dArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {   for(int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"[{i},{j},{k}] - {array[i,j,k]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

HashSet<int> numbers = new HashSet<int>(); //---Создание динамической неупорядоченной коллекции
Random rand = new Random();

int GenerateUniqueNumber()
{
    while (true)
    {
        var n = rand.Next(10, 100); //---Генерируем случайный уникальный номер из заданного диапазона
        if (!numbers.Contains(n))  //---Проверяем на неповторяемость
        {
            numbers.Add(n); //--Добавляем в коллецию
            return n;
        }
    }
}

int[,,] newArray = CreateRandome3dArray();
Show3dArray(newArray);