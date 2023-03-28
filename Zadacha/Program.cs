string[] array1 = new string[7] {"GeekBrains", "Privet", "656346", "lol", "Poka", "1", "02"};
string[] array2 = new string[array1.Length];
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void FillSecond(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
FillSecond(array1, array2);
PrintArray(array1);
System.Console.WriteLine();
PrintArray(array2);