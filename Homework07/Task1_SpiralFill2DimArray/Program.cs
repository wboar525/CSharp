//Спирально заполнить двумерный массив:     1   2   3   4 
//                                          12  13  14  5 
//                                          11  16  15  6 
//                                          10  9   8   7 ## Рекурсия
// Добавим цвета! Создадим еще один массив для "подсветки" каждого нового витка спирали

void FillArray(int[,] array, ConsoleColor[,] color_arr, int height, int width, int count, int shift) // заполняем массив заданной высоты и ширины, начиная с count со смещением shift
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
        FillArray(array, color_arr, height, width, count, shift);
    }

}


void Print2ArrayConsole(int[,] array, ConsoleColor[,] color_arr)
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
}

int a = 15;
int b = 15;
int[,] array = new int[a, b];
ConsoleColor[,] color_arr = new ConsoleColor[a,b];
FillArray(array, color_arr, a, b, 1, 0);
Print2ArrayConsole(array, color_arr);
Console.ResetColor();

