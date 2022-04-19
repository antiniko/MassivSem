int Transform(string binary)
{
    int decvis = 0;
    int n = binary.Length;
    for (int i = 0; i < n; i++)
    {
        decvis = decvis + Convert.ToInt32(Convert.ToString(binary[i]))* Convert.ToInt32(Math.Pow(2, (n-1-i)));
    }
    return decvis;
}

int[] TransformArray(int[] data, int[] info)
{
    int start = 0, end = info[0];
    int[] decvisarray = new int[info.Length];
    for (int i = 0; i < info.Length; i++)
    {
        string binary = "";
        if(start >= data.Length) 
        {
            break; 
        }
        for (int j = start; j < end; j++)
        {
            if(end > data.Length) end = data.Length; 
            binary = binary + Convert.ToString(data[j]);
        }
decvisarray[i] = Transform(binary);
        if((i + 1) == info.Length) break;
        start = start + info[i];
        end = end + info[i+1];
    }
    Console.WriteLine("[{0}]", string.Join(", ", decvisarray));
    return decvisarray;
}

Console.WriteLine("Введите количество элементов массива data:");
int datalong = Convert.ToInt32(Console.ReadLine());
int[] data = new int[datalong];
Console.WriteLine("Заполните массив data элементами чисел в двоичном представлении:");
Console.WriteLine("Внимание! Элементы могут иметь значение только 0 или 1!");
for (int i = 0; i < datalong; i++)
{
    data[i] = Convert.ToInt32(Console.ReadLine());
    if(data[i] < 0 ^ data[i] > 1)
    {
        Console.WriteLine("Вы ввели некорректное значение. Повторите ввод.");
        i--;
    }
}
Console.WriteLine("[{0}]", string.Join(", ", data));
Console.WriteLine("Введите количество элементов массива info:");
int infolong = Convert.ToInt32(Console.ReadLine());
int[] info = new int[infolong];
Console.WriteLine("Заполните массив info (целые числа больше 0):");
for (int j = 0; j < infolong; j++)
{
    info[j] = Convert.ToInt32(Console.ReadLine());
    if(info[j] <= 0)
    {
        Console.WriteLine("Вы ввели некорректное значение. Повторите ввод.");
        j--; 
    }
}
Console.WriteLine("[{0}]", string.Join(", ", info));
TransformArray(data, info);