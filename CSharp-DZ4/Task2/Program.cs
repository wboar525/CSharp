// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

long DigitSum(long number)
{
    long div1 = number % 10; // последняя цифра в числе
    long div2 = number / 10;
    long sum = div1;
    while (div2 > 0)
    {
        div1 = div2 % 10;
        sum += div1;
        div2 = div2 / 10;
    }
    return sum;
}

long RecursiveDigitSum(long digit) // через рекурсивный вызов
{
    long div = digit % 10;
    if (digit >= 10) // в числе еще есть цифры
    {
        div += RecursiveDigitSum(digit / 10); // передаем следующую цифру, раз она там есть, прибавляем ее к уже полученной рекурсивным вызовом
    }
    return div;
}

long number = 8686959547;
long sum1 = RecursiveDigitSum(number);
long sum2 = DigitSum(number);
System.Console.WriteLine(sum1 + " " + sum2);