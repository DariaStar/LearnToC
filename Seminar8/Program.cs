//Задача 53.

// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         matrix[i, j] = new Random().Next(1, 10);
//     }
// }

// void PrintMatrix(int[,] matrix)
// {
//     Console.WriteLine();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         Console.Write(matrix[i, j] + " \t");
//         Console.WriteLine();
//     }
// }

// int[,] ReleaseMatrix(int[, ] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         int x = matrix[0, i];
//         matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
//         matrix[matrix.GetLength(0) - 1, i] = x;
//     }
//     return matrix;
// }

// Console.Write("Введите кол-во строк: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во стобцов: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[n, m];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// PrintMatrix(ReleaseMatrix(matrix));


//55

// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         matrix[i, j] = new Random().Next(1, 10);
//     }
// }

// void PrintMatrix(int[,] matrix)
// {
//     Console.WriteLine();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         Console.Write(matrix[i, j] + " \t");
//         Console.WriteLine();
//     }
// }

// int[,] ReleaseMatrix(int[, ] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = i + 1; j < matrix.GetLength(1); j++)
// {
// int x = matrix[i, j];
// matrix[i, j] = matrix[j, i];
// matrix[j, i] = x;
// }
// }
// return matrix;
// }


// Console.Write("Введите кол-во строк: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во стобцов: ");
// int m = Convert.ToInt32(Console.ReadLine());
// if (n != m)
// Console.WriteLine("no");
// else
// {
// int[,] matrix = new int[n, m];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// PrintMatrix(ReleaseMatrix(matrix));
// }

// 57

// void ReleaseMatrix(int[] array)
// {
// int[] help_array = new int[array.Length];
// for (int i = 0; i < array.Length; i++)
// {
// int count = 1;
// bool flag = true;
// foreach (int el in help_array)
// {
// if (array[i] == el)
// flag = false;
// }
// if (flag)
// {
// for (int j = 0; j < array.Length; j++)
// {
// if (array[i] == array[j] && i != j)
// {
// count++;
// help_array[i] = array[i];
// }

// }
// Console.WriteLine(array[i] + " встречается " + count + " раз");
// }
// }
// }

// Console.Write("Введите кол-во строк: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во стобцов: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[n, m];
// int[] array = new int[n * m];
// InputMatrix(matrix, array);
// PrintMatrix(matrix);
// ReleaseMatrix(array);

//59

void InputMatrix(int[,] matrix)
{
int k = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = new Random().Next(1, 10);
Console.Write(matrix[i, j] + " \t");
}
Console.WriteLine();
}
}
void PrintMatrix(int[,] matrix)
{
Console.WriteLine();
int minValue = matrix[0, 0];
int row = 0, column = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
if (matrix[i, j] < minValue)
{
row = i;
column = j;
minValue = matrix[i, j];
}

}
}
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
if (i != row && j != column)
Console.Write(matrix[i, j] + " \t");
}
Console.WriteLine();
}

}

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во стобцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);