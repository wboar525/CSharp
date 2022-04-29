// Написать программу масштабирования фигуры Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком 
// (одной строкой) например: "(0,0) (2,0) (2,2) (0,2)" коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5 
// В результате показать координаты, которые получатся. при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
//
// Вводим координаты 4-х вершин (поработаем с двумерными массивами)
// Выводим координаты вершин
// Пишем метод масштабирования
// Выводим новые координаты вершин

string PrintListToString(List<double> list) //Вывод списка в строку с разделителями
{
    return String.Join(',', list);
}

List<double> CatchVertexInput() // ловим ввод с клавиатуры ЦЕЛЫХ чисел, разделенных запятой, немножко обрабатываем исключения чтобы исключить неправильный ввод данных, выход по вводу q
{
    List<double> list = new List<double> { };
    System.Console.WriteLine("Введите координаты вершины x,y разделенные запятой или введите q для выхода: ");
    string str = System.Console.ReadLine();
    while (str != "q")
    {
        try
        {
            double value1 = double.Parse(str.Split(',')[0]);
            double value2 = double.Parse(str.Split(',')[1]);
            list.Add(value1);
            list.Add(value2);
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

double CatchScale() // ловим ввод с клавиатуры ЦЕЛЫХ чисел, разделенных запятой, немножко обрабатываем исключения чтобы исключить неправильный ввод данных, выход по вводу q
{
    double value = 1;
    System.Console.WriteLine("Введите коэффициент масштабирования фигуры: ");
    string str = System.Console.ReadLine();
    try
    {
        value = double.Parse(str);
    }
    catch (FormatException)
    {
        System.Console.WriteLine("Это не вещественное число!");
    }
    return (value);
}

List<double> ScaleFigure(List<double> list, double ratio) // масштабируем фигуру
{
    for (int i = 0; i < list.Count; i++)
    {
        list[i] = list[i] * ratio;
    }
    return list;
}

List<double> list = CatchVertexInput();
double ratio = CatchScale();
System.Console.WriteLine(PrintListToString(list));
System.Console.WriteLine("Коэффициент = " + ratio);
list = ScaleFigure(list, ratio);
System.Console.WriteLine(PrintListToString(list));