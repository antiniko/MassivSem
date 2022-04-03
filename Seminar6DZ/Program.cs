﻿// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4
/*
void MoreThanZero (int [] somearray)
{
    Console.WriteLine("начните вводить числа.");
    for (int i = 0; i < somearray.Length; i++)
    somearray[i] = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Ваши числа: ");

    int result = 0;
    for (int i = 0; i < somearray.Length; i++)
    {
        Console.Write(" " + somearray[i]); 
        if (somearray[i] > 0)
        result = result + 1;
    }
    Console.Write($"\nВы ввели чисел больше 0, вот такое количесво раз: {result}");
}
  
Console.Write("Сколько чисел хотите ввести? ");
int m = Convert.ToInt32(Console.ReadLine());
int [] userarray = new int [m];
MoreThanZero (userarray);
*/

// Задача 2: Пользователь вводит с клавиатуры кол-во строк и столбцов для массива. 
// Вывести массив в виде матрицы, создав "рамку" из единиц, а внутреннюю зону матрицы заполнить нулями.

// 3, 4 ->
// 1 1 1 1
// 1 0 0 1
// 1 1 1 1

void FrameTwoDimensionalArray (int [,] framematrix) 
{
    for (int i = 0; i < framematrix.GetLength(0); i++)
    {
        for (int j = 0; j < framematrix.GetLength(1); j++)
        {
            framematrix [0, j] = 1;
            framematrix [i, 0] = 1;
            framematrix [framematrix.GetLength(0)-1, j] = 1;
            framematrix [i, framematrix.GetLength(1)-1] = 1;
            // остальное заполняется 0;
            Console.Write($"{framematrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
   
Console.Write("Введите количество рядов: ");  
int rows = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите количество строк: ");  
int columns = Convert.ToInt32(Console.ReadLine());
int [,] arrayuser = new int [rows, columns]; 
FrameTwoDimensionalArray (arrayuser);
