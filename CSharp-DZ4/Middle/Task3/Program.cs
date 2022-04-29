// Вывести сумму чисел от одного до N
// Создать массив из a элементов
// Заполнить числами от 1 до a
// Найти сумму элементов массива
// Вывести массив
// Вывести сумму

int[] CreateArray(int length)
{
    int[] array = new int[length];
    return array;
}

int[] FillArrayA(int[] array)
{
    int len = array.Length;
    for (int i = 1; i < len+1; i++)
    {
        array[i-1] = i;
    }
    return array;
}

int SumArray(int[] array)
{
    int len = array.Length;
    int sum = 0;
    for (int i = 0; i < len; i++)
    {
        sum = sum + array[i];
    }
    return sum;
}

/*void PrintArrayConsole(int[] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
       Console.Write($"{array[i]} "); 
    }
    Console.WriteLine();
} */

string PrintArrayToString(int[] array)
{
    return String.Join(',', array);
}

int a = 8;
int[] array = CreateArray(a);
FillArrayA(array);
int sum = SumArray(array);
Console.WriteLine(PrintArrayToString(array));
//PrintArrayConsole(array);
Console.WriteLine(sum);