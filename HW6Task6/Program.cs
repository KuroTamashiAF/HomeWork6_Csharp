// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента не
void FillArray(int[,] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rand.Next(0, 100);
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
void PrintIndexNumber(int[,] arr, int FindNumber)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == FindNumber)
                Console.Write($"Sring:{i} column: {j} ");
        }
    }
}
bool FindElement(int[,] arr, int FindNumber)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == FindNumber)
            {
                return true;
            }

        }
    }
    return false;
}
Console.Write("Enter number of strings: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
Console.Write("Enter the desired number: ");
int DesiredNumber = Convert.ToInt32(Console.ReadLine());
FindElement(array, DesiredNumber);
if (FindElement(array, DesiredNumber) == true)
    PrintIndexNumber(array, DesiredNumber);
else
    Console.WriteLine("There is no such element in the array");









