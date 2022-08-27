//Задача 35: Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

//[5, 18, 123, 6, 2] -> 1

int[] numbers = new int[123];

void FillArray(int[] array, int min, int max)
{
    for (int i = 0; i<array.Length; i++ )
    {
        array[i] = new Random().Next(min, max);
    }
}

void WriteArray(int[] array)
{
    for (int i = 0; i<array.Length; i++ )
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int QuantityPositive(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99 )
        {
            sum ++;
        }
    }
 return sum;
}


FillArray(numbers, 0, 1000);
WriteArray(numbers);
Console.WriteLine();

int sum = QuantityPositive(numbers);
Console.WriteLine($"количество элементов массива, значения которых лежат в отрезке: {sum}");