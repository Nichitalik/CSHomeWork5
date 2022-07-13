// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] createArray()
{
    int size = new Random().Next(3, 10);
    int[] arr = new int [size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}


int numberOfEven(int[] array)
{
    int result = 0;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result++;
        }
    }
    return result;
}


int []arr = createArray();
Console.WriteLine($"Случайный массив: {string.Join(", ", arr)}");
Console.WriteLine($"Количество четных чисел в массиве: {numberOfEven(arr)}");