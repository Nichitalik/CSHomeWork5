// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int[] createArray()
{   
    Console.Write("Введите размер массива:");
    int size = int.Parse(Console.ReadLine());
    int[] Result = new int [size];
    for (int i = 0; i < size; i++)
    {
        System.Console.Write($"Введите {i+1} элемент массива: ");
        Result[i] = int.Parse(Console.ReadLine());
    }
    return Result;
}

int difference(int[] Array)
{
    int result = 0;
    int max = Array[0];
    int min = Array[1];
    if (max < Array[1])
    {
        min = max;
        max = Array[1];
    }
    int length = Array.Length;
    for (int i = 2; i < length; i++)
    {
        if (max < Array[i])
        {
            max = Array[i];
        }
        else
        {
            if (min > Array[i])
            {
                min = Array[i];
            }
        }
    }
    result = Math.Abs(max - min);
    return result;
}


int[] arr = createArray();
System.Console.WriteLine($"Получившийся массив: {String.Join(", ", arr)}");
System.Console.WriteLine(difference(arr));