// Напишем метод преобразования десятичного целого числа в двоичное
// методом последовательного деления на 2, записывая остаток от деления В КОНЕЦ ДВОИЧНОЙ ЗАПИСИ до тех пор пока в частном от деления > 0.
// Для упрощения работы с динамическим размером данных воспользуемся СПИСКОМ, который по завершении преобразуем в массив.

int[] ConvertToBinary(int value)
{
    List<int> list = new List<int> { };

    int div1 = value;
    int div2 = 0;

    while (div1 > 0)
    {
        div2 = div1 % 2;
        div1 = div1 / 2;
        list.Add(div2);
    }
    list.Reverse(); // переворачиваем список ("В КОНЕЦ ДВОИЧНОЙ ЗАПИСИ")
    return (list.ToArray<int>()); // возвращаем массив, ну просто захотелось массивом вернуть))
}

void PrintArrayToConsole(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
    }
}

/*string PrintArrayToString(int[] array)
{
    return String.Join(' ',array);
} */

int a = 345;
int[] binary = ConvertToBinary(a);
PrintArrayToConsole(binary);