string CheckPal5Digit(int value)
{
    int d1 = value / 10000;
    int d2 = (value / 1000) % 10;
    int d4 = (value / 10) % 10;
    int d5 = value % 10;
    //    Console.WriteLine(d1+" "+d2+" "+d4+" "+d5);

    if (d1 - d5 == 0 && d2 - d4 == 0) return ("да");
    else return ("нет");
}
int value = 24542; //new Random().Next(10000,100000);
System.Console.WriteLine(value + " -> " + CheckPal5Digit(value));
