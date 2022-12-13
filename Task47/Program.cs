// Задать двумерный массив размером m x n, 
// заполненный случайными вещественными числами.

Console.Write("Введите количество строк массива : ");
var rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива : ");
int columns = int.Parse(Console.ReadLine());

double [,]array = GetArrayMatrixDouble(rows, columns, 0, 10);
PrintArray(array);

double[,]GetArrayMatrixDouble( int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    var random= new Random();

    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            result[i,j]= new Random().Next( minValue, maxValue+1 )+ random.NextDouble();
        }
    }
    return result;
}

void PrintArray(double[,]inArray)
{
    for (int i=0; i<inArray.GetLength(0); i++)
    {
        for (int j=0; j<inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}   ");
        }
          Console.WriteLine();
            
    }
}