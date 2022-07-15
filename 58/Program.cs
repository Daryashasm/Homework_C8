int rows1 = new Random().Next(2,10);
int colums1 = new Random().Next(2,10);
int [,] matrix1 = new int [rows1,colums1];
Console.WriteLine("Исходный массив №1:");
for (int i = 0; i < rows1; i++)
{
    for (int j = 0; j < colums1; j++)
    {
        matrix1[i,j] = new Random().Next(-10,10);
        Console.Write(matrix1[i,j] + " ");
    }
Console.WriteLine();
}
Console.WriteLine();

int rows2 = new Random().Next(2,10);
int colums2 = new Random().Next(2,10);
int [,] matrix2 = new int [rows2,colums2];
Console.WriteLine("Исходный массив №2:");
for (int i = 0; i < rows2; i++)
{
    for (int j = 0; j < colums2; j++)
    {
        matrix2[i,j] = new Random().Next(-10,10);
        Console.Write(matrix2[i,j] + " ");
    }
Console.WriteLine();
}
Console.WriteLine();
if (colums1 != rows2)
{
    Console.WriteLine("Умножение невозможно! Количество столбцов матрицы №1 не равно количеству строк матрицы №2.");   
}
else
{
int rows3 = rows1;
int colums3 = colums2;
int [,] matrix3 = new int [rows3,colums3];
Console.WriteLine("Произведение массива №1 на массив №2:");
for (int i = 0; i < rows3; i++)
{
    for (int j = 0; j < colums3; j++)
    {
        for (int k = 0; k < matrix2.GetLength(0); k++)
        matrix3[i,j] = matrix3[i,j] + matrix1[i,k] * matrix2[k,j];
        Console.Write(matrix3[i,j] + " ");
    }
Console.WriteLine();
}
}

