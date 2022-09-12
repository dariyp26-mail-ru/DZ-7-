/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

int[,] FillArray() // Создание массива
{
  int x = new Random().Next(1, 10);
  int y = new Random().Next(1, 10);
  int[,] array = new int[x, y];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(0, 10);
    }
  }
  return array;
}

void PrintArray(int[,] matr) // Вывод на печать
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      Console.Write($"{matr[i, j]} ");
    }
    Console.WriteLine();
  }
}

Console.WriteLine("Задайте позиции элемента в двумерном массиве m*n");
Console.WriteLine("m = ?");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("n = ?");
int n = int.Parse(Console.ReadLine());

int[,] array = FillArray(); // Создание массива

if (m > array.GetLength(0)-1 || n > array.GetLength(1)-1) Console.WriteLine("Такого числа в массиве нет."); // Проверка
else System.Console.WriteLine($"значение элемента массива = {array[m, n]}");

PrintArray(array); // Печать массива