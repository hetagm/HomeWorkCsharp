//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateRadomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1); // +1 - чтобы вошел верхний предел
    
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int ShowEvenOfNumbers( int[] array)
{
    int current = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0)
        {
            current ++;
        } 
    return current;
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимально возможное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально возможное значение: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRadomArray(size, min, max);
ShowArray(myArray);
Console.WriteLine($"Колличество четных чисел в массиве - {ShowEvenOfNumbers(myArray)}");

