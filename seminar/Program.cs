int maxnumb(int num)
{
    int n1 = num % 10;
    int n2 = num / 10;
    if(n1 > n2)
    { 
        return n1;
    }
    else
    {
        return n2;
    }
}
int number = new Random().Next(10,99);
Console.WriteLine("current number is " + number + " max part is " + maxnumb(number));
