string CheckWeekend(int value)
{
    if (value < 1 || value > 7) return ("некорректный номер дня недели");
    if (value == 6 || value == 7) return ("да");
    return ("нет");
}
int value = new Random().Next(-10, 10);
System.Console.WriteLine(value + " -> " + CheckWeekend(value));