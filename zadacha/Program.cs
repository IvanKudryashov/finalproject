string[] mas1 = new string[5] { "123", "23", "hello", "world", ":" };
string[] mas2 = new string[mas1.Length];
void FillArray2(string[] mas1, string[] mas2)
{
    int count = 0;
    for (int i = 0; i < mas1.Length; i++)
    {
        if (mas1[i].Length <= 3)
        {
            mas2[count] = mas1[i];
            count++;
        }
    }
}
void PrintArray(string[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        Console.Write($"{mas[i]} ");
    }
    Console.WriteLine();
}
FillArray2(mas1, mas2);
Console.WriteLine("Первый массив:");
PrintArray(mas1);
Console.WriteLine("Второй массив:");
PrintArray(mas2);
