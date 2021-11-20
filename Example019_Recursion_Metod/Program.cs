

void PrintArray(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++) // строки
    {
        for (int j = 0; j < matr.GetLength(1); j++) // столбцы
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++) // строки
    {
        for (int j = 0; j < matr.GetLength(1); j++) // столбцы
        {
            matr[i, j] = new Random().Next(1, 10);
        }

    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
