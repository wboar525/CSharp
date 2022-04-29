// Определить сколько чисел больше 0 введено с клавиатуры
// Будем принимать только целые числа
// Запросим ввод данных
// Передадим полученные данные в список
// посчитаем количество значений больше 0
// выведем список и количество значений

string PrintListToString(List<int> list) //Вывод списка в строку с разделителями
{
    return String.Join(',', list);
}

List<int> CatchKeyboardInput() // ловим ввод с клавиатуры ЦЕЛЫХ чисел, немножко обрабатываем исключения чтобы исключить неправильный ввод данных, выход по вводу q
{
    List<int> list = new List<int> { };
    System.Console.WriteLine("Введите целое число или нажмите q для выхода: ");
    string str = System.Console.ReadLine();
    while (str != "q")
    {
        try
        {
            list.Add(Convert.ToInt32(str));
        }
        catch (FormatException)
        {
            System.Console.WriteLine("Это не целое число, попробуйте снова!");
        }
        System.Console.WriteLine("Введите следующее целое число или нажмите q для завершения ввода: ");
        str = System.Console.ReadLine();
    }
    return (list);
}

int PositiveNum(List<int> list) // посчитаем количество значений больше 0
{
    int count = 0;
    for (int i = 0; i < list.Count; i++)
    {
        if (list[i] > 0) count++;
    }
    return (count);
}

List<int> list = CatchKeyboardInput();
string str = PrintListToString(list);
System.Console.WriteLine(str);
System.Console.WriteLine("Количество введенных чисел больше 0 с клавиатуры = " + PositiveNum(list));

