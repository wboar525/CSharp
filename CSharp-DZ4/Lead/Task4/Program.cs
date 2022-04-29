// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, 
// b1, k1, b2 и k2 заданы
// Так как с обеих сторон уравнений прямых у нас *у*, то поиск точки пересечения сведется к проверке равенства k1 * x + b1 = k2 * x + b2 или
// (k1 - k2) * x == b2 - b1 или x == (b2 - b1) / (k1 - k2)
// В уравнение любой прямой подставим полученный х для вычисления координаты y 
// Также проверим на отсутствие решения (прямые параллельны)

int CalcX(int b1, int b2, int k1, int k2) // есть деление => число может перестать быть целочисленным
{
    int x = (b2 - b1) / (k1 - k2);
    return (x);
}

int CalcY(int x, int k, int b)
{
    int y = (k * x) + b;
    return (y);
}
int k1 = 1; //new Random().Next(1,10);
int b1 = 3; //new Random().Next(1,10);

int k2 = -2; //new Random().Next(1,10);
int b2 = 12; //new Random().Next(1,10);

System.Console.WriteLine("y = k1 * x + b1, y = k2 * x + b2");
System.Console.WriteLine("k1 = " + k1 + " b1 = " + b1 + " k2 = " + k2 + " b2 = " + b2);

int x = CalcX(b1, b2, k1, k2);
int y1 = CalcY(x, k1, b1);
int y2 = CalcY(x, k2, b2);
if (y1 != y2)
{
    System.Console.WriteLine("x = " + x + " " + y1 + " != " + y2 + " Решения нет (прямые параллельны)");
}
else
{
    System.Console.WriteLine("x = " + x + " y = " + y1);
}
