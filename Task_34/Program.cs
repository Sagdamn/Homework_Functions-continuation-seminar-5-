/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

// инициализируем массив рандомными числами от 100 до 1000 длиной length
int[] InitArray(int length)
{
    int[] resultArray = new int[length];
    Random rnd = new Random();

    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = rnd.Next(100, 1000);
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

// проверяем числа в массиве на чётность + ищем количество чётных чисел в массиве
int GetSummOfEvenNumbers(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            summ ++;
    }
    return summ;
}

//получение числа с консоли
int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine() ??"");
    return result;
}

int length = GetNumber("Введите размер массива");
int[] arr = InitArray(length);
PrintArray(arr);
int summ = GetSummOfEvenNumbers(arr);

Console.WriteLine($"Массив состоит из {length} чисел, количество чётных чисел в массиве равно {summ}");