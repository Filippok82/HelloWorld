//    строка

/* string[,] table = new string[2, 5];
// String.Empty
//table[0,0] ...table[0,4]
//table[1,0] ...table[1,4]

table[1, 2] = " слово";
for (int rows = 0; rows < 2; rows++) //rows строки
{
    for (int columns = 0; columns < 5; columns++) // columns столбцы
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}

 */

// Числа
int[,] matrix = new int[3, 4];

for (int i = 0; i < matrix.GetLength(0); i++) // строки
{
    for (int j = 0; j < matrix.GetLength(1); j++) // столбцы
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}




