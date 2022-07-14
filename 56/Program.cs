Console.WriteLine("Задайте размерность прямоугольного массива rows x colums");
Console.Write("Введите rows = ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите colums = ");
int colums = Convert.ToInt32(Console.ReadLine());
if (rows == colums)
{
   Console.WriteLine("Вы задали не прямоугольный массив"); 
}
else
{
int [,] matrix = new int [rows,colums];
Console.WriteLine("Ваш массив:");
for (int i = 0; i < rows; i++)
{
for (int j = 0; j < colums; j++)
{
    matrix[i,j] = new Random().Next(-10,10);
    Console.Write(matrix[i,j] + " ");
}
Console.WriteLine();
}

sumrows(matrix);
void sumrows (int [,] matrix)
{
    int sum = 0;
    int min = 0;
    int minSum = 0;
    int [] mass = new int [rows];
Console.WriteLine();
for (int i = 0; i < rows; i++)
{
for (int j = 0; j < colums; j++)
    {
        sum = sum + matrix[i,j];
    }
Console.WriteLine($"Сумма {i} строки равна {sum}");
mass[i] = sum;
sum = 0;
}
for (int i = 0; i < rows; i++)
{
if (mass[i] < min)
{
    min = mass [i];
    minSum = i;
}
}
Console.WriteLine();
Console.WriteLine($"Наименьшая сумма элементов находится на {minSum} строке и равна {min}");
}
Console.WriteLine();
}







