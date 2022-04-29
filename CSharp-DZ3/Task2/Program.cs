double CalcDistance(int[] value1, int[] value2)
{
    double sum = 0;
    for (int i = 0; i < value1.Length; i++)
    {
        sum = sum + Math.Abs((value1[i] - value2[i]) * (value1[i] - value2[i]));
        Console.WriteLine(sum);
    }
    return (Math.Sqrt(sum));
}

int[] point1 = { 7, -5, 0 };
int[] point2 = { 1, -1, 9 };
System.Console.WriteLine(Math.Round(CalcDistance(point1, point2),2));
