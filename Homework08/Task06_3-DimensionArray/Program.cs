// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента

int[,,] Create3Array(int m, int n, int p)
{
    int[,,] array = new int[m, n, p];
    return array;
}

bool CheckRepeatingNumbers(int[,,] array, int number)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    int p = array.GetLength(2);

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < p; k++)
            {
                if (array[i, j, k] == number) return true;
            }
        }
    }
    return false;
}
int[,,] Fill3Array(int[,,] array) // заполняем массив неповторяющимися данными, с проверкой через CheckRepeatingNumbers
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    int p = array.GetLength(2);

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < p; k++)
            {
                int number = 0;
                int count = m * n * p * 1000; // введем счетчик генераций случайных чисел на случай нехватки их диапазона для уникальности каждой ячейки массива 
                while (CheckRepeatingNumbers(array, number) && count > 0)
                {
                    number = new Random().Next(10, 40);
                    count--;
                }
                array[i, j, k] = number;
            }
        }
    }
    return array;
}

int[,,] Sort3Array(int[,,] array) // сортировка 3-д массива по возрастанию разложением в одномерный -> Array.Sort -> после обратным копированием в 3-д
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    int p = array.GetLength(2);

    int[] array1 = new int[m * n * p];
    int q = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < p; k++)
            {
                array1[q] = array[i, j, k];
                q++;
            }
        }
    }

    Array.Sort(array1);

    q = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < p; k++)
            {
                array[i, j, k] = array1[q];
                q++;
            }
        }
    }
    return array;
}

void Print3ArrayConsole(int[,,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    int p = array.GetLength(2);

    array = Sort3Array(array); // отсортируем получившийся 3-д массив по возрастанию для наглядности отображения результата

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < p; k++)
            {
                Console.Write($"{array[i, j, k]} - индекс {i}, {j}, {k} \t");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int m = 3;
int n = 3;
int p = 3;

int[,,] array = Create3Array(m, n, p);
array = Fill3Array(array);
Print3ArrayConsole(array);