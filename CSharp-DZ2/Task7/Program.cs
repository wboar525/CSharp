string GetThirdDigit(int value)
{
    value = Math.Abs(value);
    if (value < 100) return ("третьей цифры нет");
    return (Convert.ToString(value % 10));
}

int value = new Random().Next(-200, 200);
System.Console.WriteLine(value + " -> " + GetThirdDigit(value));