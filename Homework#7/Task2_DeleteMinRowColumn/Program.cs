// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
// Причем, если будет встречаться 2 или более минимума, будем удалять все строки и столбцы где они встречаются вплоть до массива 0х0.

int[,] Create2Array(int m, int n)
{
    int[,] array = new int[m, n];
    return array;
}

int[,] Fill2Array(int[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

MinRC FindMinRowColumn(int[,] array)
{
    int min = array[0, 0];
    int row = 0, column = 0;
    int height = array.GetLength(0);
    int width = array.GetLength(1);
    MinRC mrc = new MinRC();
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                row = i;
                column = j;
            }
        }
    }
    mrc.min = min;
    mrc.row = row;
    mrc.column = column;
    return mrc;
}

int[,] DeleteArrayRowColumn(int[,] array, MinRC mrc) // рекурсивно удаляем все столбцы и строки с повторяющимся минимумом если такое будет встречаться
{
    int height = array.GetLength(0);
    int width = array.GetLength(1);
    int k = 0;
    int l = 0;

    int[,] new_array = new int[height - 1, width - 1];

    for (int i = 0; i < height - 1; i++)
    {
        if (k == mrc.row) k++;
        l = 0;
        for (int j = 0; j < width - 1; j++)
        {
            if (l == mrc.column) l++;
            new_array[i, j] = array[k, l];
            l++;
        }
        k++;
    }

    return new_array;
}

void Print2ArrayConsole(int[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        System.Console.WriteLine();
    }
}


int m = 3; // количество строк
int n = 4; // количество столбцов
int[,] array = Create2Array(m, n);
array = Fill2Array(array);
Print2ArrayConsole(array);

MinRC mrc = FindMinRowColumn(array);
int min = mrc.min;
do
{
    mrc.Print();
    array = DeleteArrayRowColumn(array, mrc);
    System.Console.WriteLine("Новый массив: ");
    Print2ArrayConsole(array);
    mrc = FindMinRowColumn(array);
} while(mrc.min == min);

class MinRC // поработаем с классами - данный класс содержит в себе значения минимума, его номер строки и столбца, а также функция печати текущих значений
{
    public int min = 0;
    public int row = 0;
    public int column = 0;

    public void Print()
    {
        System.Console.WriteLine($"Найден минимум массива равный {min} в строке {row+1}, столбце {column+1} ");
    }
}