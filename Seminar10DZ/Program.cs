//Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя).
//В массиве data хранится информация о количестве бит, которые занимают числа из массива info.
//Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.

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
        for (int j = start; j < end; j++)
        {
            binary = binary + Convert.ToString(data[j]);
        }
        Console.Write(binary + " ");
        decvisarray[i] = Transform(binary);
        if((i + 1) == info.Length) break;
        start = start + info[i];
        end = end + info[i+1];
    }
    Console.WriteLine("");
    Console.WriteLine("[{0}]", string.Join(", ", decvisarray));
    return decvisarray;
}

int[] info = {2, 3, 3, 1 };
int[] data = {0, 1, 1, 1, 1, 0, 1, 0, 1 };
TransformArray(data, info);