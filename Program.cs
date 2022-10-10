// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();
Console.Write("Введите номер строки: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите номер столбца: ");
int n = int.Parse(Console.ReadLine()!);

int[,] myArray = RandomArray(5, 5);
PrintArray(myArray);
if (myArray.GetLength(0) - 1 < m || myArray.GetLength(1) - 1 < n) Console.WriteLine("Нет такого элемента");
else Console.WriteLine(myArray[m, n]);


int[,] RandomArray(int m, int n)
{
    int[,] newArray = new int[m, n];
    Random randGenerator = new Random();
    for (int i = 0; i < m; i++) for (int j = 0; j < n; j++) newArray[i, j] = randGenerator.Next(-100, 100);
    return newArray;
}

void PrintArray(int[,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++) Console.Write($"{newArray[i, j]}; ");
        Console.WriteLine("");
    }
}
