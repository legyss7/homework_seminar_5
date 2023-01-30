/* Задача 38: Задайте массив целых чисел. Найдите разницу между 
максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

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
        array[i] = rmd.Next(0, 101);
    }
    Console.Write($"[{string.Join(", ", array)}]");
    return array;
}

int DifferentMaxMinElements(int[] arr)
{
    int dif = 0;
    int max = arr[0];
    int min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
        if(arr[i] < min) min = arr[i];
    }
    dif = max - min;
    return dif;
}

Console.WriteLine(" -> {0}", DifferentMaxMinElements(CreatingAndFillingArray(EnterArraySize())));