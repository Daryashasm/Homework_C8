int N = 4, M = 4;
int[,] matrix = new int[N,M];
int rows = 0, colums = 0, x = 1, y = 0, dirChanges = 0, gran = M;
    for (int i = 0; i < matrix.Length; i++)
    {
    matrix[rows,colums] = i + 1;
        if (--gran == 0)
        {
        gran = N * (dirChanges % 2) + M * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
        int temp = x;
        x = -y;
        y = temp;
        dirChanges = dirChanges + 1;
        }
        rows = rows + x;
        colums = colums + y;
    }
        for (int j = 0; j < N; j++)
        {
            for (int i = 0; i < M; i++)
            {
                Console.Write(matrix[i,j] + " ");
            }
            Console.WriteLine();
        }