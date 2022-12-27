string[] arr = new string[] {"hello", "2", "world", "1234", "-2", "1567", "Russia", ":-)"};

Console.WriteLine("Первоначальный массив");
PrintArray(arr);
Console.WriteLine();
Console.WriteLine("Обработанный массив");
PrintArray(ArrRes(ArrSize(arr),arr));

// Методы

// Определение длины массива
int ArrSize(string[] str)
{
    int k = 0;
    for(int i=0;i<str.Length;i++)
    {
        if (str[i].Length <= 3) k++;
    }
    return k;
}

//Формирование массива
string[] ArrRes(int size, string[] str)
{
    int k = 0;
    string[] arres = new string[size];
    for(int i=0;i<str.Length;i++)
    {
        if (str[i].Length <= 3)
        {
            arres[k] = str[i];
            k++;
        }
    }
    return arres;
}

//Вывод массива
void PrintArray(string[] str)
{
    for(int i=0;i<str.Length;i++)
    {
        if (i<str.Length-1) Console.Write($" \"{str[i]}\", ");
        else Console.Write($" \"{str[i]}\"");
        
    }

}