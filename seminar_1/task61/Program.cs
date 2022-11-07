// Показать треугольник Паскаля. *Сделать вывод в виде равнобедренного треугольника.
using System;
using static System.Console;

Clear();
int[,] array = Triangle(10);
DisplayTriangle(array);

int[,] Triangle(int level)
{
    int[,] result = new int[level, level];
    result[0, 0] = 1;
    for (int i = 1; i < level; i++)
    {
        result[i, 0] = 1;
        result[i, i] = 1;
        for (int j = 1; j < level - 1; j++)
            result[i, j] = result[i - 1, j - 1] + result[i - 1, j];
    }
    return result;
}

void DisplayTriangle(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        DisplaySpace(array.GetLength(0)- i);
        for (int j = 0; j < i + 1; j++){
            Write(array[i, j]);
            if (array[i, j] > 0 & array[i, j] < 10)
                Write("     ");
            else if (array[i, j] > 9 && array[i, j] < 100)
                Write("    ");
            else if (array[i, j] > 99 && array[i, j] < 1000)
                Write("   "); 
            else if (array[i, j] > 999 && array[i, j] < 10000)
                Write("  ");   
        }
        WriteLine();
    }
}

void DisplaySpace(int i)
{
    if (i > 0)
    {
        Write("   ");
        DisplaySpace(i-1);
    }
}