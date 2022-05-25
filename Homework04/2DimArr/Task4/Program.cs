// Задать двумерный массив следующим правилом: Aₘₙ = m+n
// Создать массив из mxn элементов
// Заполнить значениями Aₘₙ = m+n
// Вывести массив на экран

int[,] Create2Array(int m, int n)
{
    int[,] array = new int[m, n];
    return array;
}

int[,] Fill2ArrayAmn(int[,] array)
{
    int m = array.GetUpperBound(0) + 1;
    int n = array.Length / m;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

void Print2ArrayConsole(int[,] array)
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

int m = 3; // количество строк
int n = 3; // количество столбцов
int[,] array = Create2Array(m, n);
Fill2ArrayAmn(array);
Print2ArrayConsole(array);
