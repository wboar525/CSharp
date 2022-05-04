// Показать числа Фибоначчи
// Покажем числа Фибоначчи по запросу числа N, где N - номер числа Фибоначчи начиная с 0
// Ряд Фибоначчи - числа, каждое последующее число которого равно сумме двух предыдущих чисел начиная с 0 и 1
// Сделаем 2 метода - через массив/список и без него


List<int> BuildFibo(int value)
{
    List<int> list = new List<int> { };

    list.Add(0);
    list.Add(1); // из определения ряда Фибоначчи

    for (int i = 2; i < value; i++)
    {
        int prev1 = list[list.Count - 1];
        int prev2 = list[list.Count - 2];
        list.Add(prev1 + prev2);
    }
    return (list); // тут вернем список
}

string BuildFiboString(int value) // без массива, прямо в строку через запятую
{
    string str = String.Empty;

    double prev1 = 0;
    double prev2 = 1;
    double summ = 0;

    str = Convert.ToDouble(prev1) + ",";
    str += Convert.ToDouble(prev2);

    for (int i = 2; i < value; i++)
    {
        summ = prev1 + prev2;
        str += "," + Convert.ToDouble(summ);
        prev1 = prev2;
        prev2 = summ;
    }
    return str;
}

string PrintListToString(List<int> list)
{
    return String.Join(',', list);
}

int a = 15;
string str = String.Empty;
str = BuildFiboString(a);
System.Console.WriteLine(str);

List<int> list = BuildFibo(a);
System.Console.WriteLine(PrintListToString(list));
