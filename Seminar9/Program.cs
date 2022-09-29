// Разворот

// void rec(string s2, string c)
// {
// string s1;
// int i;
// if (s2.Length == 0)
// Console.WriteLine(c);
// else
// {
// for (i = 0; i < s2.Length; i++)
// {
// c += s2[i];
// s1 = s2;
// s1 = s1.Remove(i, 1);
// rec(s1, c);
// c = c.Remove(c.Length - 1, 1);
// }
// }
// }


// int i;
// string? s, c, s2;
// s = Console.ReadLine();
// for(i = 0; i < s.Length; i++)
// {
// c = Convert.ToString(s[i]);
// s2 = Convert.ToString(s);
// s2 = s2.Remove(i, 1);
// rec(s2, c);
// }


// 60 task

// Console.Write("Введите длину массива: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите ширину массива: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите высоту массива: ");
// int z = Convert.ToInt32(Console.ReadLine());
// int[,,] matrix = new int[x, y, z];
// int n = 10;
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// for(int k = 0; k < matrix.GetLength(2); k++)
// {
// matrix[i, j, k] = n;
// Console.WriteLine($"{matrix[i, j, k]} ({i}, {j}, {k})");
// n++;
// }
// }
// }

//62 

// Console.Write("Введите число элементов в основании треугольника Паскаля: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int i, c;
// float factorial(int n)
// {
// float i, x = 1;
// for (i = 1; i <= n; i++)
// x *= i;
// return x;
// }

// for (i = 0; i < n; i++)
// {
// for (c = 0; c <= (n - i); c++)
// Console.Write(" ");
// for (c = 0; c <= i; c++)
// {
// Console.Write(" ");
// Console.Write(factorial(i) / (factorial(c) * factorial(i - c)));
// }
// Console.WriteLine();
// Console.WriteLine();
// }
// Console.ReadLine();