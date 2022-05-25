// Скопировать массив
// Создать массив из N элементов
// Заполнить числами от 0 до 99, возьмем случайные целые числа
// Выведем его на экран
// Скопируем его в новый массив
// Выведем новый массив

int[] CreateArray(int length)
{
    int[] array = new int[length];
    return array;
}

int[] FillRandomArray(int[] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

int[] CopуArray(int[] array) // копируем массив в новый массив
{
    int len = array.Length;
    int[] new_array = new int[len];
    for (int i = 0; i < len; i++)
    {
        new_array[i] = array[i];
    }
    return new_array;
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

int N = 8;
int[] array = CreateArray(N);
FillRandomArray(array);
Console.WriteLine(PrintArrayToString(array));
int[] new_array = CopуArray(array);
Console.WriteLine(PrintArrayToString(new_array));
//PrintArrayConsole(array);