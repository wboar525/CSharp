// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
#nullable disable // передача значений NULL исключена

int[,] Create2Array(int m, int n)
{
    int[,] array = new int[m, n];
    return array;
}

void Fill2Array(int[,] array)
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

int ReadUserNumber()
{
    string str = String.Empty;
    int num = 0; 
    while(str != "q")
    {
        try
        {
            System.Console.WriteLine("Введите целое число: ");
            num = Convert.ToInt32(str = System.Console.ReadLine());
            return num;
        }
        catch
        {
            if (str != "q") System.Console.WriteLine("Введено не целое число, попробуйте еще раз или введите q для выхода со значением 0!");
        }
    }
    return 0;
}

(int, int) ReturnNumberPosition(int[,] array, int num)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] == num) return (i,j);
        }
    }
    return (-1,-1);
}

int m = 3; // количество строк
int n = 4; // количество столбцов
int[,] array = Create2Array(m, n);
Fill2Array(array);
Print2ArrayConsole(array);
int num = ReadUserNumber();
(int a, int b) = ReturnNumberPosition(array,num);
if (a == -1 || b == -1)
{
    System.Console.WriteLine("Значение в массиве не найдено!");
}
else
{
    System.Console.WriteLine($"Значение найдено в строке {a+1}, столбце {b+1}");
}