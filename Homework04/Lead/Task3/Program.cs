// Напишем метод преобразования десятичного целого числа в двоичное
// методом последовательного деления на 2, записывая остаток от деления В КОНЕЦ ДВОИЧНОЙ ЗАПИСИ до тех пор пока в частном от деления > 0.
// Для упрощения работы с динамическим размером данных воспользуемся СПИСКОМ, который по завершении преобразуем в массив.
// Второй способ - без массива/списка, возврат результата в вещественную переменную

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
    return (list.ToArray<int>()); // возвращаем массив
}

double ConvertToBinaryNoArray(int value) // без массива/списка
{
    int div1 = value;
    int div2 = 0;
    double result = 0;
    double mult = 1;

    while(div1 > 0)
    {
        div2 = div1 % 2;
        div1 = div1 / 2;
        result = result + div2*mult;
        mult *= 10;
    }

    return (result);
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

int a = 93568;
int[] binary = ConvertToBinary(a);
double bin = ConvertToBinaryNoArray(a);
System.Console.WriteLine(bin);
PrintArrayToConsole(binary);