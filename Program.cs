string[] InitArray()
{
    string[] array = new string[4];

    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine("Введите текст для массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

string [] StandardArray ()
{
    string [] standard = new string [4];

    for (int i = 0; i < standard.Length; i++)
    {
        standard [i] = string.Empty;
    }
    return standard;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
}



