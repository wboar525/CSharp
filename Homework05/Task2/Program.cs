// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// **Нечетные позиции в массиве-это позиции с четной индексацией, и наоборот**
// Создаем новый массив и заполняем случайными числами
// вычисляем сумму элементов стоящих на нечет позициях
// Выводим массив
// выводим сумму

int[] CreateAndFillArray(int n)
{
    int[] array = new int[n];
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(0,100);
    }
    return array;
}

int CountSumOddPosArray(int[] array)
{
    int len = array.Length;
    int sum = 0;
    for (int i = 0; i < len; i+=2)
    {
        sum += array[i];
    }
    return sum;
}

string PrintArrayToString(int[] array)
{
    return String.Join(',', array);
}

int n = 7;
int[] array = CreateAndFillArray(n);
int sum = CountSumOddPosArray(array);
System.Console.WriteLine(PrintArrayToString(array));
System.Console.WriteLine("sum = "+sum);
