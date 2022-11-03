/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму
элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] InitArray(int length)
{
    int[] resultArray = new int[length];
    Random rnd = new Random();

    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = rnd.Next(0, 10);
    }
    return resultArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// проверяем числа в массиве на нечётность + ищем сумму элементов, стоящих на нечётных позициях
int GetSummOfNumbersOfOddIndexes(int[] array)
{
    int summ = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        summ = summ + array[i];
    }
    return summ;
}

//получение числа с консоли
int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int length = GetNumber("Введите размер массива");
int[] arr = InitArray(length);
PrintArray(arr);
int summ = GetSummOfNumbersOfOddIndexes(arr);

Console.WriteLine($"Массив состоит из {length}, сумма элементов, стоящих на нечётных позициях равна {summ}");