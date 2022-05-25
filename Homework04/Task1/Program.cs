// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

double ADegreeB(double A, double B)
{
    double result = A;
    for (int i = 1; i < B; i++)
    {
        result *= A;
    }
    return result;
}

double A = 2;
double B = 16;
double result = ADegreeB(A, B);
System.Console.WriteLine("A = " + A + " в натуральной степени B = " + B + " равно " + result);
//double control = Math.Pow(A,B);
//System.Console.WriteLine(control);