// трехзначные числа могут быть и отрицательными, работаем с ними по модулю
int GetSecondDigit(int value)
{
    value = Math.Abs(value);
    int a = (value % 100) / 10;
    return a;
}

int value = new Random().Next(100,1000);
System.Console.WriteLine(value+" -> "+ GetSecondDigit(value));