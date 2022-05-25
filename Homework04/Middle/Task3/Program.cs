// Вывести сумму чисел от одного до N
// Создать массив из a элементов
// Заполнить числами от 1 до a
// Найти сумму элементов массива
// Вывести массив
// Вывести сумму

double[] CreateArray(int length)
{
    double[] array = new double[length];
    return array;
}

double[] FillArrayA(double[] array)
{
    int len = array.Length;
    for (int i = 1; i < len + 1; i++)
    {
        array[i - 1] = i;
    }
    return array;
}

double SumArray(double[] array)
{
    int len = array.Length;
    double sum = 0;
    for (int i = 0; i < len; i++)
    {
        sum = sum + array[i];
    }
    return sum;
}

/*void PrintArrayConsole(double[] array)
{
    double len = array.Length;
    for (double i = 0; i < len; i++)
    {
       Console.Write($"{array[i]} "); 
    }
    Console.WriteLine();
} */

double CalcSumFormula(int n)
{
    return (((n + 1) * n) / 2);
}

string PrintArrayToString(double[] array)
{
    return String.Join(',', array);
}

int a = 25;
double[] array = CreateArray(a);
FillArrayA(array);
//double sum = SumArray(array);
double sum = CalcSumFormula(a);
Console.WriteLine(PrintArrayToString(array));
//PrintArrayConsole(array);
Console.WriteLine(sum);