// Для простоты и наглядности при тестировании берем как в примере, первое число двузначное, второе число - однозначное
// Программа корректно работает с целыми числами при условии value2 != 0
int GetMult(int value1, int value2)
{
    return(value1 % value2);
}

int value1 = new Random().Next(10,100);
int value2 = new Random().Next(1,10);

int residue = GetMult(value1, value2);
if (residue == 0)
{
    System.Console.WriteLine(value1 + ", " + value2 + " -> "+" кратно");
}
else
{
    System.Console.WriteLine(value1 + ", " + value2 + " -> "+" не кратно, остаток " + residue);
}
