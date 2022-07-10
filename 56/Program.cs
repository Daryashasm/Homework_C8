//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.WriteLine("Задайте размерность прямоугольного массива m х n");
Console.Write("Введите m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n = ");
int n = Convert.ToInt32(Console.ReadLine());
int rows = m;
int colums = n;
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







