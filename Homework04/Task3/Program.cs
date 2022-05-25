// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] CreateAndFillArray(int size) // создадим массив заданного размера из случайных целых чисел
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

string ArrayToString(int[] array) // выведем в строку методом String.Join
{
    return (String.Join(",", array));
}

int size = 8;
System.Console.WriteLine(ArrayToString(CreateAndFillArray(size)));