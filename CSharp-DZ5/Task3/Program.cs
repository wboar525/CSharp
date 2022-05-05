// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Создаем массив вещественных чисел случайными числами от 1 до 99
// вычисляем максимум и минимум, вычисляем разницу макс и мин
// Выводим массив и разницу

double[] CreateAndFillArray(int n)
{
    double[] array = new double[n];
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().NextDouble()*99;
    }
    return array;
}

double CalcMaxMinAndDiffArray(double[] array)
{
    int length = array.Length;
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    return (max-min);
}

string PrintArrayToString(double[] array)
{
    return String.Join(' ', array);
}

int a = 6;
double[] array =  CreateAndFillArray(a);
double sum = CalcMaxMinAndDiffArray(array);
System.Console.WriteLine(PrintArrayToString(array));
System.Console.WriteLine(sum);