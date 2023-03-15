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

void CheckAndRecord(string[] array, string [] standard)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        int check = 3;
        if (check >= array[i].Length)
        {
            standard[i] = array[i];
        }
    }
}

string[] array = InitArray();
string []standard = StandardArray();

PrintArray(array);
System.Console.WriteLine();

CheckAndRecord(array,standard);
standard = standard.Where(n => !string.IsNullOrEmpty(n)).ToArray();
PrintArray(standard);

