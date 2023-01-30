/* Задача 36: Задайте одномерный массив, заполненный случайными 
числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

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
        array[i] = rmd.Next(-10, 11);
    }
    Console.Write($"[{string.Join(", ", array)}]");
    return array;
}

int sumOfOddElements(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(i % 2 != 0) sum += arr[i];
    }
    return sum;
}

Console.WriteLine(" -> {0}", sumOfOddElements(CreatingAndFillingArray(EnterArraySize())));