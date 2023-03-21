// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
int[,] ReturnMatrix(int rows, int columns, int min, int max)
{
    var rand = new Random();
    int[,] myArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            myArray[i, j] = rand.Next(min, max + 1);

        }

    }
    return myArray;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Please, enter quantity of rows and columns with space between: ");
string[] line1 = Console.ReadLine()!.Split(" ");
int rows = int.Parse(line1[0]);
int columns = int.Parse(line1[1]);

Console.Write("Please, enter min and max with space between: ");
string[] line2 = Console.ReadLine()!.Split(" ");
int min = int.Parse(line2[0]);
int max = int.Parse(line2[1]);

int[,] needMatrix = ReturnMatrix(rows, columns, min, max);
PrintMatrix(needMatrix);

int[,] SortRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int[] tempRow = new int[matrix.GetLength(1)]; //create a template array with numbers feom row
        for (int j = 0; j < (matrix.GetLength(1)); j++) tempRow[j] = matrix[i, j];// adding numbers to array
        int size = matrix.GetLength(1);
        int temp;
        for (int m = 0; m < size - 1; m++)
        {
            for (int k = m + 1; k < size; k++)
            {
                if (tempRow[m] < tempRow[k])
                {
                    temp = tempRow[m];
                    tempRow[m] = tempRow[k];
                    tempRow[k] = temp;
                }
            }
        }
        for (int z = 0; z < size; z++) matrix[i, z] = tempRow[z];
    }
    return matrix;
}
Console.WriteLine();

int[,] sortMatrix = SortRows(needMatrix);
Console.WriteLine("Your sorted matrix:");
PrintMatrix(sortMatrix);
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
// ДОП

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

