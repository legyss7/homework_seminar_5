/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int EnterArraySize()
{
    int sizeArray;
    while (true)
    {
        Console.Write("Задайте размер массива (от 3 и более): ");
        if (int.TryParse(Console.ReadLine(), out sizeArray))
        {
            sizeArray = Math.Abs(sizeArray);
            if (sizeArray > 2) break;
            else Console.WriteLine("Введите число большее двух!");
        }
        else Console.WriteLine("Введенное число содержит символ!");
    }
    return sizeArray;
}

int[] CreatingAndFillingArray(int size)
{
    int[] array = new int[size];
    Random rmd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rmd.Next(100, 1000);
    }
    Console.Write($"[{string.Join(", ", array)}]");
    return array;
}

int SearchForEvenNumbers(int[] arr)
{
    int evenNumberCounter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0) evenNumberCounter++;
    }
    return evenNumberCounter;
}

Console.WriteLine(" -> {0}", SearchForEvenNumbers(CreatingAndFillingArray(EnterArraySize())));
