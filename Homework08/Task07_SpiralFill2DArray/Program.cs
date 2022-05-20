//Спирально заполнить двумерный массив:     1   2   3   4 
//                                          12  13  14  5 
//                                          11  16  15  6 
//                                          10  9   8   7 ## Рекурсия
// Добавим цвета! Создадим еще один массив для "подсветки" каждого нового витка спирали
// Также добавим метод, разворачивающий спираль против часовой стрелки

void FillSpiralArray(int[,] array, ConsoleColor[,] color_arr, int height, int width, int count, int shift) // заполняем массив заданной высоты и ширины, начиная с count со смещением shift
{
    ConsoleColor[] colors = (ConsoleColor[]) ConsoleColor.GetValues(typeof(ConsoleColor));
    ConsoleColor color = colors[0];
    int color_index;
    color_index = new Random().Next(1,15);
    color = colors[color_index];
    for (int i = shift; i < width - 1; i++)
    {
        array[shift, i] = count;
        color_arr[shift,i] = color;
        count++;
    }

    for (int i = shift; i < height - 1; i++)
    {
       array[i, width - 1] = count;
        color_arr[i,width-1] = color;
        count++;
    }

    for (int i = width - 1; i >= shift; i--)
    {
        array[height - 1, i] = count;
        color_arr[height -1, i] = color;
        count++;
    }

    for (int i = height - 2; i >= 1 + shift; i--)
    {
        array[i, shift] = count;
        color_arr[i, shift] = color;
        count++;
    }
    width--;
    height--;
    if (width > 0 && height > 0)
    {
        shift++;
        FillSpiralArray(array, color_arr, height, width, count, shift);
    }

}

int[,] CounterclockRotateSpiral(int m, int n) // построим спираль, а потом развернем ее против часовой стрелки
{
    ConsoleColor[,] color_arr = new ConsoleColor[m,n];
    var arr = new int[m,n];
    FillSpiralArray(arr, color_arr, m, n, 1, 0);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n/2; j++)
        {
            int tmp = arr[i, j]; // на примере начала цикла: запоминаем элемент 1-й строки 1-го столбца
            arr[i, j] = arr[i, m - j - 1]; // вместо этого элемента вставляем значение из ячейки 1-й строки последнего столбца
            arr[i, m - j - 1] = tmp; // в последний столбец записываем первый элемент массива
        }
    }
    return arr;
}

void Print2ArrayConsole(int[,] array, ConsoleColor[,] color_arr) // вывод массива с цветовой подсветкой
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.ForegroundColor = color_arr[i,j];
            Console.Write($"{array[i, j]} \t");
        }
        System.Console.WriteLine();
    }
    Console.ResetColor();
}

int a = 8;
int b = 8;
ConsoleColor[,] color_arr = new ConsoleColor[a,b];
int[,] array = new int[a,b];
FillSpiralArray(array,color_arr, a, b, 1, 0);
Print2ArrayConsole(array, color_arr);
System.Console.WriteLine();

var arr = CounterclockRotateSpiral(a,b);
Print2ArrayConsole(arr,color_arr);


