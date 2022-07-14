int rows = new Random().Next(1,5);
int colums = new Random().Next(1,5);
int faces = new Random().Next(1,5);
int [] repeats = new int [100];
int [,,] matrix = new int [rows,colums,faces];
Console.WriteLine("Исходный трехмерный массив:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < colums; j++)
    {
        for (int k = 0; k < faces; k++)
        {
        matrix[i,j,k] = new Random().Next(10,99);
        repeats[matrix[i,j,k]] = repeats[matrix[i,j,k]] + 1;
        while (repeats[matrix[i,j,k]] > 1)
            {
                matrix[i,j,k] = new Random().Next(10,99);

            }
        Console.Write($"[{i},{j},{k}] = {matrix[i,j,k]}" + "  ");
        }
    Console.WriteLine();
    }
Console.WriteLine();
}