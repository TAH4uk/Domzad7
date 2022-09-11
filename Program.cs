// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Console.Write("Введите количество строк: ");
// int NumberRow = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int NumberColumn = Convert.ToInt32(Console.ReadLine());
// double[,] number = new double[NumberRow, NumberColumn];
// FillArrayRandomNumbers(number);
// Console.WriteLine();
// PrintArray(number);

// void FillArrayRandomNumbers(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(-10, 10)) / 10;
//         }
//     }
// }

// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine();
//     }
// }

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Console.Write("Введите номер строки: ");
// int NumberRow = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите номер столбца: ");
// int NumberColumn = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// int[,] number = new int[3, 3];
// FillArrayRandomNumbers(number);

// if (NumberRow > number.GetLength(0) || NumberColumn > number.GetLength(1))
//     {
//         Console.WriteLine("Такого элемента в массиве НЕТ!");
//     }
//     else
//     {
//         Console.WriteLine($"Значение элемента {NumberRow}-ой строки и {NumberColumn}-ого столбца равно {number[NumberRow - 1, NumberColumn - 1]}");
//     }

// Console.WriteLine();
// PrintArray(number);

// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(-10, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine();
//     }
// }