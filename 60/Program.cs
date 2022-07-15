int x = new Random().Next(1,5);
int y = new Random().Next(1,5);
int z = new Random().Next(1,5);
int [] iterator = new int [100];
int [,,] matrix = new int [x,y,z];
Console.WriteLine("Исходный трехмерный массив:");
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        for (int k = 0; k < z; k++)
        {
        matrix[i,j,k] = new Random().Next(10,99);
        iterator[matrix[i,j,k]] = iterator[matrix[i,j,k]] + 1;
        while (iterator[matrix[i,j,k]] > 1)
            {
                matrix[i,j,k] = new Random().Next(10,99);

            }
        Console.Write($"[{i},{j},{k}] = {matrix[i,j,k]}" + "  ");
        }
    Console.WriteLine();
    }
Console.WriteLine();
}