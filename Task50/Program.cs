// Написать программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или уже указание,
// что такого элемента нет.

Console.Write("Введите количество строк исходного массива : ");
var rows = int.Parse(Console.ReadLine());
int m = rows;
Console.Write("Введите количество столбцов исходного массива : ");
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

Console.Write("Введите номер строки элемента  массива : ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца элемента  массива : ");
int N = int.Parse(Console.ReadLine());
if (M<m || N<n)
{
    Console.WriteLine( $"Элемент  массива с позицией ( {M},{N} ) равен {array[M,N]} ");
}   
else   
{
    Console.WriteLine( $"Элемента с указанной позицией ( {M},{N} ) в массиве нет");
}   