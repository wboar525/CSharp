// Для простоты и наглядности берем как в примере числа от 10 до 999. Программа работает с любыми целыми числами.

string CheckMult(int value)
{
    int d1 = value % 7;
    int d2 = value % 23;
    if (d1 == 0 && d2 == 0) return ("да");
    return ("нет");
}

int value = new Random().Next(10, 1000);
System.Console.WriteLine(value + " -> " + CheckMult(value));
