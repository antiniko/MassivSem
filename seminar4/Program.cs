/*
// Задача 1.
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int exp (int a,int b)
{
    int result = 1;
    if (b > 0)
    {
        for(int i = 1; i <= b; i++)
        {
            result = result*a;
        }
    }
    return result;
}



Console.Write("Введите число возводимое в степень: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите в какую степень возводить число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Результатом сложнейших математических вычислений является число " + exp(a, b));
*/

/*
// Задача 2.
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11

int Sum(int num)
{
    if(num < 0)
    {
        num = -1*num;
    }
    int result = num%10;
    while(num/10 > 0)
    {
        num = num/10;
        result = result + num%10;
    }
    return result;
}
Console.Write("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Сумма цифр числа "  + N + " равняется " + Sum(N));
*/

// Задача 3.
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

void Array(int N)
{
    int[] array = new int [N];
    for(int i = 0; i < N; i++)
    {
        Console.Write("Введите следующий элемент массива:");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("[{0}]", string.Join(", ", array));
}
Console.Write("Введите размерность массива: ");
int Size = Convert.ToInt32(Console.ReadLine());
Array(Size);