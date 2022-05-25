int GetQuartNumber(int x, int y)
{
    if (x > 0 && y > 0) return (1);
    if (x < 0 && y > 0) return (2);
    if (x < 0 && y < 0) return (3);
    return (4);
}

int x = 0;
int y = 0;
while (x == 0) x = new Random().Next(-10, 10);
while (y == 0) y = new Random().Next(-10, 10);
Console.WriteLine("x = " + x + " y = " + y + " -> " + GetQuartNumber(x, y));
