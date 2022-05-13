void PrintArrayShift(int[] array, int n)
{
    int len = array.Length;

    for (int j = 0; j < n; j++)
    {
        System.Console.Write("    ");
    }

    for (int i = 0; i < array.Length; i++)
    {
        int num = array[i];
        switch(num)
        {
            case >= 1000:
            System.Console.Write($"{num}    ");
            break;

            case >= 100:
            System.Console.Write($" {num}    ");
            break;

            case >= 10:
            System.Console.Write($"  {num}    ");
            break;

            default:
            System.Console.Write($"   {num}    ");
            break;
        }
    }
    System.Console.WriteLine();
}

void PrintPascalTriangle(int[] array, int n)
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

    PrintArrayShift(array, n);
    n--;
    if (n > 0) PrintPascalTriangle(new_array, n);
}

int[] array = new int[1];
array[0] = 1;
int n = 15;
PrintPascalTriangle(array, n);