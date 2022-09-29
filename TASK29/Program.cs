// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] CreateArray(int size)
{
    int[] newArray = new int[size];
    
    int i = 0;

    while(i < size)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
        i++;
    }

    return newArray;
}

void ShowArray( int[] array)
{
    Console.WriteLine("Вывод массива: ");
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Введите размер массива: ");
int SizeArray = Convert.ToInt32(Console.ReadLine());

ShowArray(CreateArray(SizeArray));
