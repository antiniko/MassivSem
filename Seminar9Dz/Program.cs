// Задача 1. Сделать вывод треугольника Паскаля в виде равнобедренного треугольника.

Console.Write("введите порядок степени: ");
int Counter = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < Counter; i++) // счётчик
{
    for (int j = Counter; j > i + 1; j--) // отступ до середины треугольника. вот он гугл всемогущийБ сократил код раза в 2
    {
        Console.Write(" ");
    }
    int triangle = 1;
    for (int j = 0; j <= i; j++)
    {
        Console.Write(triangle + " ");
        triangle = (triangle * (i - j)) / (j + 1);
    }
    Console.WriteLine();
}