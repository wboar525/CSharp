// Для простоты и наглядности берем как в примере числа от -99 до 99. Программа работает с любыми целыми числами.

string CheckSquareRoot(int value1, int value2)
{
    int square1 = value1 * value1;
    int square2 = value2 * value2;
    if (value1 == square2 || value2 == square1) return ("да");
    return ("нет");
}

int value1 = new Random().Next(-99, 100);
int value2 = new Random().Next(-99, 100);
System.Console.WriteLine(value1 + ", " + value2 + " -> " + CheckSquareRoot(value1, value2));
