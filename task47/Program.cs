/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

void PrintArray(double[,] matr) //Вывод на печать
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

void FillArray(double[,] matr) //Заполнение массива
{
  double temp = 0;
  int x2 = 0;
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      x2 = new Random().Next(1, 3); // Для создания целых и дробных в равной пропорции
      if (x2 == 1) matr[i, j] = new Random().Next(-9, 10);
      else
      {
        temp = new Random().Next(-99, 100);
        matr[i, j] = temp / 10;
      }
    }
  }
}

Console.WriteLine("Задайте размер двумерного массива m×n");
Console.WriteLine("m = ?");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("n = ?");
int n = int.Parse(Console.ReadLine());

double[,] matrix = new double[m, n];
PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);