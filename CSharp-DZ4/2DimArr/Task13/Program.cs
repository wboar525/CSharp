// Составить частотный словарь элементов двумерного массива
// Используем словарь класса SortedDictionary (самостоятельное изучение, docs.microsoft.com - Руководство по языку C#)

int[,] CreateAndFill2Array(int m, int n) // сгенерируем 2d массив из случайных чисел от 0 до 9 
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return (array);
}

void Print2ArrayConsole(int[,] array) // выведем двумерный массив на печать
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

SortedDictionary<int, int> GenFreqVocab(int[,] array) // для генерации сразу будем использовать класс SortedDictionary, чтобы было сразу как в примере
{
    int m = array.GetUpperBound(0) + 1;
    int n = array.GetUpperBound(1) + 1;
    var vocab = new SortedDictionary<int, int>(); // определение типа переменной по типу выражения справа (docs.microsoft.com)
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (!vocab.ContainsKey(array[i, j]))
            {
                vocab.Add(array[i, j], 1);
            }
            else
            {
                vocab[array[i, j]]++;
            }
        }
    }
    return vocab;
}

void PrintDictionary(SortedDictionary<int, int> vocab)
{
    foreach (var entry in vocab) // определение переменной без типа, компилятор сам выводит тип переменной из выражения справа (ключи словаря)
    {
        Console.WriteLine("Цифра " + entry.Key + " встречается " + entry.Value + " раз(a)");
    }
}

int m = 4;
int n = 4;
int[,] array = CreateAndFill2Array(m, n);
Print2ArrayConsole(array);
SortedDictionary<int, int> vocab = GenFreqVocab(array);
PrintDictionary(vocab);
//System.Console.WriteLine(String.Join(",", vocab));
