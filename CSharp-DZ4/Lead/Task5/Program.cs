// Показать числа Фибоначчи
// Покажем числа Фибоначчи по запросу числа N, где N - номер числа Фибоначчи начиная с 0
// Ряд Фибоначчи - числа, каждое последующее число которого равно сумме двух предыдущих чисел начиная с 0 и 1


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

string PrintListToString(List<int> list)
{
    return String.Join(',', list);
}

int a = 15;
List<int> list = BuildFibo(a);
System.Console.WriteLine(PrintListToString(list));
