// // Сбор черники
// Console.Clear();
// Console.Write("Введите кол-во кустов: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[n];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 10);

// Console.WriteLine("Исходный массив: [" + string.Join(", ", array) + "]");

// int[] result_array = new int[n];
// for (int i = 1; i < array.Length - 1; i++)
// {
//     result_array[i - 1] = array[i - 1] + array[i] + array[i + 1];
// }
// result_array[result_array.Length - 2] = array[array.Length - 1] + array[0] + array[1];
// result_array[result_array.Length - 1] = array[0] + array[array.Length - 1] + array[array.Length - 2];
// Console.WriteLine("Конечный массив: [" + string.Join(", ", result_array) + "]");

// int max_number = result_array[0];
// for (int i = 1; i < result_array.Length; i++)
// {
//     if (max_number < result_array[i])
//         max_number = result_array[i];
// }
// Console.WriteLine(max_number);

// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

// 31

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10);
// }

// int SummaPositive(int[] array)
// {
//     int summa_p = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//             summa_p += array[i];
//     }
//     return summa_p;
// }

// int SummaNegative(int[] array)
// {
//     int summa_n = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < 0)
//             summa_n += array[i];
//     }
//     return summa_n;
// }

// int[] arr = new int[12];
// InputArray(arr);
// Console.WriteLine("Исходный массив данных: [" + string.Join(", ", arr) + "]");
// Console.WriteLine("Сумма положительных чисел равна: " + SummaPositive(arr));
// Console.WriteLine("Сумма отрицательных чисел равна: " + SummaNegative(arr));


// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 


// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10);
// }


// int[] ChangeModule(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = (-1) * array[i];
//     }
//     return array;
// }

// int[] arr = new int[12];
// InputArray(arr);
// Console.WriteLine("Исходный массив данных: [" + string.Join(", ", arr) + "]");
// Console.WriteLine("Конечный массив данных: [" + string.Join(", ", ChangeModule(arr)) + "]");


    // Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10);
// }

// string SearchNumber(int[] array, int number)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == number)
//             return "такое есть";
//     }
//     return "такого нет";
// }

// int[] array = new int[12];
// InputArray(array);
// Console.WriteLine("Исходный массив данных: [" + string.Join(", ", array) + "]");
// Console.Write("Введите число, которое нужно найти: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(SearchNumber(array, n));


// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-100, 101);
// }

// int SearchNumbers(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 10 && array[i] <= 99)
//             count++;
//     }
//     return count;
// }

// int[] array = new int[123];
// InputArray(array);
// Console.WriteLine("Исходный массив данных: [" + string.Join(", ", array) + "]");
// Console.WriteLine("Кол-во чисел в промежутке [10, 99]: " + SearchNumbers(array));



// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 10);
}

void Pairresult(int[] array)
{
    int lenArray;

    if (array.Length % 2 == 0)
        lenArray = array.Length / 2;
    else
        lenArray = array.Length / 2 + 1;

    int[] ResultArray = new int[lenArray];

    for (int i = 0; i < lenArray; i++)
    {
       ResultArray[i] = array[i] * array[array.Length - i - 1];
    }
    Console.WriteLine("Конечный массив данных: [" + string.Join(", ", ResultArray) + "]");
}

int[] array = new int[5];
InputArray(array);
Console.WriteLine("Исходный массив данных: [" + string.Join(", ", array) + "]");
Pairresult(array);
