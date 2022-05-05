// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// Создаем новый массив и заполняем случайными полож 3-х значными числами
// вычисляем кол-во четных чисел
// Выводим массив
// выводим кол-во четных чисел

int[] CreateAndFillArray(int n)
{
    int[] array = new int[n];
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
    return array;
}

int CountEvenArray(int[] array)
{
    int len = array.Length;
    int count = 0;
    for (int i = 0; i < len; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

string PrintArrayToString(int[] array)
{
    return String.Join(',', array);
}

int n = 7;
int[] array = CreateAndFillArray(n);
int count = CountEvenArray(array);
System.Console.WriteLine(PrintArrayToString(array));
System.Console.WriteLine(count);
