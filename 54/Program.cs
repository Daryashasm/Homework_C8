int rows = new Random().Next(1,10);
int colums = new Random().Next(1,10);
int [,] matrix = new int [rows,colums];
for (int i = 0; i < rows; i++)
{
for (int j = 0; j < colums; j++)
{
    matrix[i,j] = new Random().Next(-10,10);
    Console.Write(matrix[i,j] + " " );
}
Console.WriteLine();
}
Console.WriteLine();
void sortElements (int [,] matrix)
{
int x = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < (matrix.GetLength(1)-1); k++)
        {
        if (matrix[i,k] < matrix[i,k+1])
        {
            x = matrix[i,k+1];
            matrix[i,k+1] = matrix[i,k];
            matrix[i,k] = x;
        }
        }
    }
}
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i,j] + " " );
    }
Console.WriteLine();
}
}
sortElements(matrix);