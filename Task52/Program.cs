// Задать двумерный массив из целых чисел.
// Найти среднее арифметическое элементов в каждом столбце.


Console.Write("Введите количество строк массива : ");
var rows = int.Parse(Console.ReadLine());
int m = rows;
Console.Write("Введите количество столбцов массива : ");
int columns = int.Parse(Console.ReadLine());
int n = columns;

int[,]array = GetArrayMatrix(rows, columns, 0, 9);
Console.WriteLine("Исходная матрица : ");
PrintArray(array);

int[,]GetArrayMatrix( int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            result[i,j]= new Random().Next(minValue, maxValue+1 );
        }
    }
    return result;
}


void PrintArray(int[,]inArray)
{
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            Console.Write($"{inArray[i,j]}  ");
        }
        Console.WriteLine();
    }
}


for (int j=0; j<n; j++) 
{
   double summ = 0;

    for(int i=0; i< m; i++) 
    { 
       summ = summ + array[i,j];
    }
    double average = summ/(m);  
    Console.WriteLine($" Среднее арифметическое столбца {j} равно { average}");
}