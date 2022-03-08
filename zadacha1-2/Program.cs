/*
int X(int num)
{
    int n1 = num / 100;
    int n2 = (num / 10) - (n1 * 10);
    int n3 = num - (n1 * 100 + n2 * 10);
    return (n1 * 10) + n3;
}
int number = new Random().Next(100,999);
Console.WriteLine("current number is " + number + " part is " + X(number));
*/

/*
void F(int num1, int num2)
{
    if(num2 < num1)
    {
        Console.WriteLine("второе число меньше первого ");
    }
    else if (num2 % num1 == 0)
    {
        Console.WriteLine("второе число кратно первому");
    }
    else
    Console.WriteLine(num2 % num1);
}
Console.Write("введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
F(number1, number2);
*/

/*
//Написать программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
int GetQuart(double xpoint, double ypoint)
{
    if(xpoint > 0 && ypoint > 0) return 1;
    if(xpoint < 0 && ypoint > 0) return 2;
    if(xpoint < 0 && ypoint < 0) return 3;
    if(xpoint > 0 && ypoint < 0) return 4;
    return 0;
}

double x, y;
int quartNum;
Console.WriteLine("input x: ");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input y: ");
y = Convert.ToDouble(Console.ReadLine());
quartNum = GetQuart(x,y);
if (quartNum == 0)
{
    Console.WriteLine("нельзя однозначно определить четверть");
}
else
{
    Console.WriteLine("Данная точка назодится в " + quartNum + "четверти");
}
*/


/*
// Написать программу, которая принимает на вход номер четверти ивыводит на экран диапазон координат, доступных в этой четверти
void GetQuart(int numQuad)
{
    if(numQuad == 1)
    {
        Console.WriteLine("в данной четверти координаты могут быть в следующем диапозоне: x>0, y>0");
    } 
    if(numQuad == 2)
    {
        Console.WriteLine("в данной четверти координаты могут быть в следующем диапозоне: x<0,y>0");
    }
    if(numQuad == 3)
    {
        Console.WriteLine("в данной четверти координаты могут быть в следующем диапозоне: x<0,y<0");
    }
    if(numQuad == 4)
    {
        Console.WriteLine("в данной четверти координаты могут быть в следующем диапозоне: x>0,y<0");
    }
}


int quartNum;
Console.WriteLine("input numQuad(1-4): ");
quartNum = Convert.ToInt32(Console.ReadLine());
GetQuart(quartNum);
*/

/*
// Написать программу, которая принимает на вход номер четверти ивыводит на экран диапазон координат, доступных в этой четверти. через case
void GetQuart(int numQuad)
{
    switch(numQuad)
    {
        case 1:
        {
        Console.WriteLine("в данной четверти координаты могут быть в следующем диапозоне: x>0, y>0");
        break;
        }
        case 2:
        {
        Console.WriteLine("в данной четверти координаты могут быть в следующем диапозоне: x<0,y>0");
        break;
        }
        case 3:
        {
        Console.WriteLine("в данной четверти координаты могут быть в следующем диапозоне: x<0,y<0");
        break;
        }
        case 4:
        {
        Console.WriteLine("в данной четверти координаты могут быть в следующем диапозоне: x>0,y<0");
        break;
        }
        default:
        {
        Console.WriteLine("не верно введено число");
        break;
        }
    }
}


int quartNum;
Console.WriteLine("input numQuad(1-4): ");
quartNum = Convert.ToInt32(Console.ReadLine());
GetQuart(quartNum);
*/

//Написать программу, принимающую на вход координаты двух точек и определяющую расстояние между ними

double GetDistance(double x1, double y1, double x2, double y2)
{
    double xDistance = x2 - x1;
    double yDistance = y2 - y1;

    return Math.Sqrt(Math.Pow(xDistance,2) + Math.Pow(yDistance,2));
}

double xA, yA, xB, yB;

Console.Write("input x for point A: ");
xA = Convert.ToDouble(Console.ReadLine());
Console.Write("input y for point A: ");
yA = Convert.ToDouble(Console.ReadLine());
Console.Write("input x for point B: ");
xB = Convert.ToDouble(Console.ReadLine());
Console.Write("input x for point B: ");
yB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(GetDistance(xA, yA, xB, yB));
