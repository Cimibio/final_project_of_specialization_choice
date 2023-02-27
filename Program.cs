// выборка из массивов строк элементов длинной 3 и меньше
void PrintArray(string[] arg)
{
    for (int i = 0; i < arg.Length; i++)
    {
        Console.Write(arg[i] + ", ");
    }
}

string[] Select(string[] array)
{
    string[] new_array = new string[array.Length];
    int n = 0;
    for (int i = 0; i < array.Length; i++)
    {
    
        if (array[i].Length <= 3) 
        {
            new_array[n] = array[i];
            n++;
        }
    }
    Array.Resize(ref new_array, n);
    return new_array;
}

string[] array_of_string_1={"Hello", "2", "world", ":-)"};
string[] array_of_string_2={"1234", "1567", "-2","computer sience"};
string[] array_of_string_3={"Russia", "Denmark", "Kazan_bral"};

Console.WriteLine("Первый массив:");
PrintArray(Select(array_of_string_1));
Console.WriteLine();
Console.WriteLine("Второй массив:");
PrintArray(Select(array_of_string_2));
Console.WriteLine();
Console.WriteLine("Третий массив:");
PrintArray(Select(array_of_string_3));