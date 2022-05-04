// Показать двумерный массив размером m×n заполненный вещественными числами
// Создать массив из mxn элементов
// Заполнить случайными вещественными числами от 0 до 999
// Вывести массив на экран

double[,] Create2Array(int m, int n)
{
    double[,] array = new double[m, n];
    return array;
}

double[,] Fill2Array(double[,] array)
{
    int m = array.GetUpperBound(0) + 1;
    int n = array.Length / m;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().NextDouble()*999;
        }
    }
    return array;
}

void Print2ArrayConsole(double[,] array)
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
}

/* string PrintArrayToString(int[,] array)
{
    int m = array.GetUpperBound(0)+1;
    int n = array.Length / m;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j]} \t");            
        }
    }
} */

int m = 3; // количество строк
int n = 6; // количество столбцов
double[,] array = Create2Array(m, n);
Fill2Array(array);
Print2ArrayConsole(array);
