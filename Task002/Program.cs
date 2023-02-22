/*
Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/

int[,] InitMatrix()
{
int[,] matrix = new int[3,4];
Random rnd = new Random();

for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i,j] = rnd.Next(-10,10);
}
}

return matrix;
}

void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
Console.Write($"{matrix[i,j]} ");
}
Console.WriteLine();
}
}

Console.WriteLine("Введите число");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);

void SearchEvenNumber (int number, int[,] matrix)
{    
    for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
    if (number == matrix[i, j])
    { 
    Console.WriteLine($"{number} -> такое число есть");
    break;
    }
    else
    {
        Console.WriteLine($"{number} -> такого числа нет");
    }
}
}
}

int[,] matrix = InitMatrix();
PrintMatrix(matrix);
Console.WriteLine ();
SearchEvenNumber (number, matrix);