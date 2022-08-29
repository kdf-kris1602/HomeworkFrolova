
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
            matr[i, j] = new Random().Next(1,10);// [1;10)
        }
    }
}

int[,] matrix = new int[3,4];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

double sum1 = (matrix[0,0] + matrix[1,0] + matrix[2,0]) / 3;
double sum2 = (matrix[0,1] + matrix[1,1] + matrix[2,1]) / 3;
double sum3 = (matrix[0,2] + matrix[1,2] + matrix[2,2]) / 3;
double sum4 = (matrix[0,3] + matrix[1,3] + matrix[2,3]) / 3;

Console.Write(sum1 + "; " + sum2 + "; " + sum3 + "; " + sum4);

