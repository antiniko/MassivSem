/*
// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void RandomArray (int m, int n)
{
    double [,] matrix = new double [m, n];
    
    Console.WriteLine("Вот что сгенерировали: ");

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix [i, j] = Convert.ToDouble(new Random().Next(-99, 100) / 10.0); // Рандом от -9.9 до 9.9. немного странно, но по другому не работает :(
            Console.Write($"{matrix [i, j]} ");  
        }
        Console.WriteLine();
    } 
}
Console.Write("Введите количество рядов: "); 
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество колонн: ");
int columns = Convert.ToInt32(Console.ReadLine());
RandomArray (rows, columns);
*/

/*
// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 7 -> такого числа в массиве нет


void FindByIndex(int index, int jindex)
{
    int[,] secondmatrix = new int [3, 4];

    int elementarray = 0;
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            secondmatrix[i, j] = new Random().Next(10);
            Console.Write($"{secondmatrix[i, j]} ");
            if (index == i || jindex == j)
            elementarray = secondmatrix[index, jindex];
        }
        Console.WriteLine();
    }
    Console.WriteLine($"Искомый элемент: {elementarray}.");
}
Console.Write("Введите номер в ряду: ");
int rowindex = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер в колонне: ");
int columnindex = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[3, 4];
if (rowindex < 3 && columnindex < 4) // Опять же отсчет начинается с 0.0 
FindByIndex(rowindex, columnindex);
else
Console.Write("Массив меньше искомых чисел!");

*/


// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] RandomArray (int [,] arrayTwoDimensional)
{
    for (int i = 0; i < arrayTwoDimensional.GetLength(0); i++)
    {
        for (int j = 0; j < arrayTwoDimensional.GetLength(1); j++)
        {
            arrayTwoDimensional [i, j] = new Random().Next (0, 10); // Рандом от 0 до 9
            Console.Write($"{arrayTwoDimensional[i, j]}\t");
        }
        Console.WriteLine();
    }
    return arrayTwoDimensional;
}

void ArrayColumns (int [,] arrayTwoDimensional)
{
    Console.WriteLine("Среднее арифметическое каждого столбца:");

    for (int j = 0; j < arrayTwoDimensional.GetLength(1); j++)
    {
        double arithmetmean = 0;
        double columnsum = 0;
        for (int i = 0; i < arrayTwoDimensional.GetLength(0); i++)
        {
            columnsum = columnsum + arrayTwoDimensional [i, j];
            arithmetmean = Math.Round(columnsum/arrayTwoDimensional.GetLength(0), 1); // каким то чудом делает что хотелось.
        }
        Console.Write($"{arithmetmean}\t");   
        
    }    
}

Console.Write("Введите количество рядов: "); 
int rows = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите количество колонн: ");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] arrayTwoDim = new int [rows, columns];
RandomArray (arrayTwoDim);
ArrayColumns (arrayTwoDim);
