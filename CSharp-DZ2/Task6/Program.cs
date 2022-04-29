int Get2Digit(int value)
{
    return (Math.Abs((value % 1000) / 100));
}

int value = new Random().Next(-9999, -999);
System.Console.WriteLine(value + " -> " + Get2Digit(value));