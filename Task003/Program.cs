/*
Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int[,] InitMatrix()
{
int[,] matrix = new int[3,4];
Random rnd = new Random();

for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i,j] = rnd.Next(1,50);
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

double SearchANumber (int[,] matrix)
{
double result = 0.0;

    for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
    if (j == 0)
    { 
    result = result + matrix[i,j];
    }
   
}
}
return result;

}

double SearchBNumber (int[,] matrix)
{
double result = 0.0;

    for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
    if (j == 1)
    { 
    result = result + matrix[i,j];
    }
   
}
}
return result;

}
double SearchCNumber (int[,] matrix)
{
double result = 0.0;

    for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
    if (j == 2)
    { 
    result = result + matrix[i,j];
    }
   
}
}
return result;

}
double SearchENumber (int[,] matrix)
{
double result = 0.0;

    for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
    if (j == 3)
    { 
    result = result + matrix[i,j];
    }
   
}
}
return result;

}

int[,] matrix = InitMatrix();
PrintMatrix(matrix);
Console.WriteLine ();
double result = SearchANumber (matrix);
double b = SearchBNumber (matrix);
double c = SearchCNumber (matrix);
double e = SearchENumber (matrix);
double itog = result / 3;
double bitog = b / 3;
double citog = c / 3;
double eitog = e / 3;
Console.WriteLine ($"{itog}; {bitog}; {citog}; {eitog}");
