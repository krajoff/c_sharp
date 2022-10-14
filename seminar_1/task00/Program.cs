using System;
using static System.Console;

Clear();
int[] size = { 4, 4 };
DisplayRow(int[] {4, 4});


void DisplayRow(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "  ");
}