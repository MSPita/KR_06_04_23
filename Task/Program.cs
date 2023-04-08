Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine()!);
string[] arr = new string[m];

void Array(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} строку ");
        arr[i] = Console.ReadLine()!;

    }

}
string[] Master(string[] arr)
{
    int n = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
            n++;
    }

    string[] newarr = new string[n];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newarr[j] = arr[i];
            j++;
        }
    }    
    return newarr;
}

void Print(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.Write("]");
}
Array(arr);
Print(arr);

string[] newarr2 = Master(arr);
Print(newarr2);
