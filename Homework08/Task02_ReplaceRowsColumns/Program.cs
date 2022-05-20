// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

void Print2ArrayConsole(int[,] array) // выводим массив на печать
{
    int m = array.GetUpperBound(0) + 1;
    int n = array.GetUpperBound(1) + 1;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] Fill2ArrayRandom(int[,] array) // заполняем массив случайными числами
{
    int m = array.GetUpperBound(0) + 1;
    int n = array.Length / m;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0,100);
        }
    }
    return array;
}
int[,] ReplaceRowsWithColumns(int[,] array) // меняем строки на столбцы
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    int[,] new_array = new int[m,n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            new_array[i,j] = array[j,i];
        }
    }
    return new_array;
}

bool CheckArraySize(int[,] array) // проверяем равенство столбцов и строк
{
    return(array.GetLength(0) == array.GetLength(1));
}

int m = 5;
int n = 5;
int[,] array = new int[m,n];
array = Fill2ArrayRandom(array);
Print2ArrayConsole(array);
System.Console.WriteLine();
if (!CheckArraySize(array)) 
{
    System.Console.WriteLine("Число строк не равно числу столбцов! Останов программы");
    System.Console.ReadKey();
    return;
}
Print2ArrayConsole(ReplaceRowsWithColumns(array));