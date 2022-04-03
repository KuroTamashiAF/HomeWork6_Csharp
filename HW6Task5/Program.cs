// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} {" "}");
        }
        Console.WriteLine();
    }
}
void ReplacingElements(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                arr[i,j]*=arr[i,j];
            }
        }
    }

}
Console.Write("Enter number of strings: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
ReplacingElements(array);
Console.WriteLine();
PrintArray(array);
