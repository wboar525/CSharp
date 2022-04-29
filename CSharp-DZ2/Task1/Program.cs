int GetValue(int value)
{
    int a = value / 10;
    int b = value % 10;

    if (a>b) return a;
    return b;
}

int value = new Random().Next(10, 100);
System.Console.WriteLine(value + " -> " + GetValue(value));
