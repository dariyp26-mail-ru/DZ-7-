/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

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

void AverageСolumn(int[,] matr)
{
  double average = 0;
  Console.Write("Среднее арифметическое каждого столбца: ");
  for (int i = 0; i < matr.GetLength(1); i++)
  {
    for (int j = 0; j < matr.GetLength(0); j++)
    {
      average = average + matr[j, i]; // Складываем цифры в столбце
    }
    average = average / matr.GetLength(0); // Полученную сумму столбца делим на кол-во цифр в столбце
    Console.Write(Math.Round(average, 2)); // Округление до двух знаков после запятой
    if (i == matr.GetLength(1) - 1) Console.Write(".");  // Если последнее число, то ставится точка
    else Console.Write("; ");                           // иначе - ;
    average = 0; // Сброс переменной для следующего подсчета средне арифметического
  }
}

int[,] array = FillArray(); // Создание массива
PrintArray(array); // Печать массива
AverageСolumn(array); // Расчет и печать средне арифметического