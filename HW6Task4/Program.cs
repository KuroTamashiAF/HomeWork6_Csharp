// В двумерном массиве n×k заменить четные элементы на противоположные
void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 101);
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
void ReplacingEvenElements(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] % 2 == 0)
            {
                arr[i, j]= -arr[i, j];
            }
        }
    }

}
Console.Write("Enter number of strings: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of columns: ");
int k = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, k];
FillArray(array);
PrintArray(array);
ReplacingEvenElements(array);
Console.WriteLine();
PrintArray(array);