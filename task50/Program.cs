
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine(); 
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void SearchArray(int[,] matr)
{
    Console.WriteLine("Введите координаты x и у, чтобы узнать какое число стоит на этом месте, х: ");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("y: ");
    int j = Convert.ToInt32(Console.ReadLine());

    if (i < matr.GetLength(0) || j < matr.GetLength(1))
    {     
        Console.WriteLine( "в данных координатах находится число - " + matr[i, j]);
    }
    else 
    {
        Console.WriteLine("вы ввели неверные координаты");
    }
}

void NumbersArray(int[,] matr)
{
    Console.WriteLine("Введите число, на проверку наличия его в массиве ");
    int number = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (number == matr[i, j])
            {
                Console.WriteLine( number + "стоит на позиции [" + i + ", " + j + "]" );
            }  
        }
    }
    Console.WriteLine(number + " такого числа в массве нет");
}

int[,] matrix = new int[3, 4];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
SearchArray(matrix);
NumbersArray(matrix);
