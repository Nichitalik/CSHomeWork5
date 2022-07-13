// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] createArray()
{
    int size = new Random().Next(3, 10);
    int[] arr = new int [size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(-99, 100);
    }
    return arr;
}


int arraySum(int[] array)
{
    int result = 0;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (i % 2 > 0)
        {
            result += array[i];
        }
    }
    return result;
}

int []arr = createArray();
Console.WriteLine($"Случайный массив: {string.Join(", ", arr)}");
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {arraySum(arr)}");