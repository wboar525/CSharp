// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
// Показать только нечетные числа в треугольнике

void PrintArrayShift(int[] array, int n, bool OnlyOdd) // вывод треугольника со смещениями относительно левого угла консоли
{
    int len = array.Length;

    for (int j = 0; j < n; j++)
    {
        System.Console.Write("    ");
    }

    for (int i = 0; i < array.Length; i++)
    {
        int num = array[i];
        if (OnlyOdd && num % 2 == 0) 
        {
            System.Console.Write("        ");
        }
        else if (num > 999)
        {
            System.Console.Write($"{num}    ");
        }
        else if (num > 99)
        {
            System.Console.Write($" {num}    ");
        }
        else if (num > 9)
        {
            System.Console.Write($"  {num}    ");
        }
        else
        {
            System.Console.Write($"   {num}    ");
        }
    }
    System.Console.WriteLine();
}

void PrintPascalTriangle(int[] array, int n, bool OnlyOdd) // вывод треугольника через рекурсию
{
    int len = array.Length;
    int[] new_array = new int[len + 1];
    int new_len = new_array.Length;
    new_array[0] = 1;
    new_array[new_len - 1] = 1;
    for (int i = 0; i < len - 1; i++)
    {
        new_array[i + 1] = array[i] + array[i + 1];
    }

    PrintArrayShift(array, n, OnlyOdd);
    n--;
    if (n > 0) PrintPascalTriangle(new_array, n, OnlyOdd);
}

int[] array = new int[1];
array[0] = 1;
int n = 15;
bool OnlyOdd = false; // флажок, переключающий режим отображения треугольника
PrintPascalTriangle(array, n, OnlyOdd);