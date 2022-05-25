int[] GetSqSheet(int N)
{
    int[] result = new int[N];
    for (int i = 1; i <= result.Length; i++)
    {
        result[i-1] = i * i * i;
    }
    return (result);
}

int N = 7;
int[] sheet = GetSqSheet(N);
for (int i = 0; i<sheet.Length; i++)
{
    Console.Write(sheet[i]+" ");
}
