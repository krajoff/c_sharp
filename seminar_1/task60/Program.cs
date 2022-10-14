// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя 
// индексы каждого элемента. Массив размером 2 x 2 x 2: 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0), 27(0,0,1) 90(0,1,1), 26(1,0,1) 55(1,1,1)
using System;
using static System.Console;

Clear();
int[,,] array = new int[2, 2, 2];
for (int k = 0; k < array.GetLength(2); k++)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j, k] = CheckValue(array);
        }
    }
}
DisplayThreeDimentionalArray(array);


int CheckValue(int[,,] array)
{
    int m, value;
    do
    {
        m = 0;
        value = new Random().Next(10, 100);
        for (int k = 0; k < array.GetLength(2); k++)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    m += (array[i, j, k] == value) ? 1 : 0;
                }
            }
        }
    }
    while (m > 0);
    return value;
}


void DisplayThreeDimentionalArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j, k] + $"({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}