// Показать двумерный массив размером m×n заполненный вещественными числами
void FillArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().NextDouble()*100;
        }
    }
}
void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}+{" "}");
        }
        Console.WriteLine();
    }
}

Console.Write("Enter number of strings: ");
int NumberStrings = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of сolumn: ");
int NumberColumn = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[NumberStrings, NumberColumn];
FillArray(array);
PrintArray(array);