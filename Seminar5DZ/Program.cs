﻿// Задача 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*
void NumberEvenArray(int N)
{
    int[] array = new int[N];
    int counter = 0;
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        if(array[i]%2 == 0) {counter++;}
    }
    Console.WriteLine("Сгенерировано " + "{0}", string.Join(", ", array) + ". Внутри четных чисел " + counter);
}
Console.Write("Введите длину массива: ");
int N = Convert.ToInt32(Console.ReadLine());
NumberEvenArray(N);
*/

// Задача 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19

void SummOddPositionArray(int N)
{
   int[] array = new int[N];
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 5);
        if(i%2 > 0) {sum = sum + array[i];}
    }    
    Console.WriteLine("Сгенерировано " + "{0}", string.Join(", ", array) + " Сумму элементов, стоящих на нечётных позициях: " + sum);
    // счёт начинается с 0... значит второй элемент на самом деле является первым(не четным)
}
Console.Write("Введите длину массива: ");
int N = Convert.ToInt32(Console.ReadLine());
SummOddPositionArray(N);


// Задача 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
/*
void MaxMinDifferent (double[] array)
{
    int maxArrayIndex = 1;
    int minArrayIndex = 0;
    if(array[0] >= array[1]) 
    {
        maxArrayIndex = 0;
        minArrayIndex = 1;
    }
    for(int i = 2; i < array.Length; i++)
    {
        if(array[i] > array[maxArrayIndex]) {maxArrayIndex = i;}
        if(array[i] < array[minArrayIndex]) {minArrayIndex = i;}
    }
    double diff = array[maxArrayIndex] - array[minArrayIndex];
    Console.WriteLine("Разница между максимальным и минимальным элементами: " + "{0}", string.Join(", ", array) + " равна: " + diff);
}
double[] Array = {-10,20,30,40,50,6,70};
MaxMinDifferent(Array);
*/