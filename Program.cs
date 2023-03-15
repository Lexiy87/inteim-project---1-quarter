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





