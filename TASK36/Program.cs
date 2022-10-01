//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateRadomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1); 
    
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int SumOfElements( int[] array)
{
    int current = 0;
    for(int i = 1; i < array.Length; i = i +2)
        current += array[i];
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
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях - {SumOfElements(myArray)}");