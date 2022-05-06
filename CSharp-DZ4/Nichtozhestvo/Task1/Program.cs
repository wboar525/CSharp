/* Есть два массива info и data.
Массив data состоит из нулей и единиц хранящий числа в двоичном представлении. Числа идут друг за другом без разделителей.
Массив info состоит из чисел, которые представляют колличество бит чисел из массива data.
Составить массив десятичных представлений чисел массива data с учётом информации из массива info.
Пример:
```
входные данные:
data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
info = {2, 3, 3, 1 }

выходные данные:
1, 7, 0, 1 
Из метода ручного перевода из одной системы в другую - для перевода двоичного числа в десятичное, используем метод суммирования значений полученных при возведении 2 в степень номера положения бита 1 в записи двоичного числа
справа налево, начиная с 0
Пример: 0111 в десятичной системе будет равно:
        1*2^0 + 1*2^1 + 1*2^2 + 0 = 1 + 2 + 4 = 7
*/

bool CheckArrays(int[] data, int[] info)
{
    if (info.Sum() != data.Length) // размеры массивов не соответствуют
    {
        System.Console.WriteLine("Неполные данные!");
        return false;
    }

    for (int i = 0; i < data.Length; i++)
    {
        if (data[i] != 0 && data[i] != 1)
        {
            System.Console.WriteLine("Не двоичные данные в массиве data!");
            return false;
        }
    }
    return true;
}

double[] ConvertBinToDec(int[] data, int[] info)
{
    int bin_size = data.Length;
    int dec_size = info.Length;
    double[] array = new double[dec_size];

    int count = 0; // указатель положения в массиве с двоичными данными
    for (int i = 0; i < dec_size; i++)
    {
        int bin_length = info[i];
        double result = 0;
        for (int j = bin_length - 1; j >= 0; j--)
        {
            if (data[count] > 0) result += Math.Pow(2, j); // суммируем получившиеся значения, нули игнорируем
            count++; // счетчик общего положения в массиве data 
        }
        array[i] = result;
    }
    return (array);
}

int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1, 1};
int[] info = { 2, 3, 3, 2 };

bool ok = CheckArrays(data, info);
{
    if (!ok) return;
}

double[] result = ConvertBinToDec(data, info);
System.Console.WriteLine(String.Join(",", result));
