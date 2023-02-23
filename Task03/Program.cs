// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int numRows = SetNumber("Rows ");
int numColumns = SetNumber("Columns ");

var matrix = GetMatrix(numRows, numColumns);
Print(matrix);

int SetNumber(string numberName)
{
Console.Write($"Enter number {numberName}: ");
int num = Convert.ToInt32(Console.ReadLine());
return num;
}

int [,] GetMatrix (int rows, int columns)
{
int [,] matrix = new int [rows, columns];
for (int i = 0; i < rows; i++)
{
for (int l = 0; l < columns; l++)
{
matrix [i, l] = i + l;
}
}
return matrix;
}

void Print(int [ , ] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int l = 0; l < matrix.GetLength(1); l++)
{
System.Console.Write(matrix[i, l] + " ");

}
System.Console.WriteLine();
}
}
// void ArithmeticMean(int[,] matrix)

// {

//     for (int l = 0; l < matrix.GetLength(1); l++)

//     {
//         double result = 0;
//         for (int i = 0; i < matrix.GetLength(0); i++)

//         {
//             result += matrix[i, l];
//         }
//         Console.WriteLine();
//         Console.Write($"arithmetic");
//         Console.Write($"{Math.Round(result / matrix.GetLength(0), 1)}" + " ");
//     }
//     Console.WriteLine();
// }
ArithmeticMean(matrix);

void ArithmeticMean(int[,] matrix) 
{
    for (int l = 0; l < matrix.GetLength(1); l++)
    {
        double sum = 0;
        double average = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, l];
        }
        average = sum / matrix.GetLength(0);
        System.Console.WriteLine($"column {l}: {Math.Round(average)}");
    }
}