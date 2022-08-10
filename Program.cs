string[] GenerateRandomArray(string[] RandomArray)
{
    for (int i = 0; i < RandomArray.Length; i++)
    {
        Console.Write("Введите значение элемента массива: ");
        RandomArray[i] = Console.ReadLine();
    }
    return RandomArray;
}
void PrintArray(string[] RandomArray)
{
    for (int i = 0; i < RandomArray.Length; i++)
    {
        Console.Write($"{RandomArray[i]} ,");
    }
}
string[] CheckArrayElements(string[] RandomArray)
{
    int k = 0;
    for (int i = 0; i < RandomArray.Length; i++)
    {
        if (RandomArray[i].Length <= 3)
        {
            k++;
        }
    }
    string[] SecondArray = new string[k];
    k = 0;
    for (int i = 0; i < RandomArray.Length; i++)
    {
        if (RandomArray[i].Length <= 3)
        {
            SecondArray[k] = RandomArray[i];
            k++;
        }
    }
    PrintArray(SecondArray);
    return RandomArray;
}

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] myarray = new string[size];
GenerateRandomArray(myarray);
Console.Write($"[");
PrintArray(myarray);
Console.Write("] -> [");
CheckArrayElements(myarray);
Console.Write("]");