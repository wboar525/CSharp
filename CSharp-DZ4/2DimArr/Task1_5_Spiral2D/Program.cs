//Спирально заполнить двумерный массив:     1   2   3   4 
//                                          12  13  14  5 
//                                          11  16  15  6 
//                                          10  9   8   7 ## Рекурсия

void FillArray(int[,] array, int height, int width, int count, int shift) // заполняем массив заданной высоты и ширины, начиная с count со смещением shift
{
    for (int i = shift; i < width-1; i++)
    {
        array[shift,i] = count;
        count++;
    }
  
    for (int i = shift; i < height-1; i++)
    {
        array[i,width-1] = count;
        count++;
    }

    for (int i = width - 1; i >= shift ; i--)
    {
        array[height-1,i] = count;
        count++;        
    }

    for (int i = height - 2; i >= 1+shift ; i--)
    {
        array[i,shift] = count;
        count++;
    }
    width--;
    height--;
    if (width > 0 && height > 0) 
    {
        shift++;
        FillArray(array,height,width,count,shift);
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

int a = 4;
int b = 4;
int[,] array = new int[a,b];
FillArray(array,a,b,1,0);
Print2ArrayConsole(array);

