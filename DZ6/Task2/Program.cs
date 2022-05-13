// Найти произведение двух матриц
// Матрицы A и B могут быть перемножены, если они совместимы в том смысле, что число столбцов матрицы A равно числу строк B.

int[,] Fill2Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void Print2ArrayConsole(int[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        System.Console.WriteLine();
    }
}

bool IsMatrixCompatible(int[,]A, int[,]B)
{
    if (A.GetLength(1) != B.GetLength(0)) return false;
    else return true;
}

int[,] MultiMatrix(int[,] A, int[,] B)
{
    int a_rows = A.GetLength(0);
    int a_cols = A.GetLength(1);
    int b_rows = B.GetLength(0);
    int b_cols = B.GetLength(1);
    int[,] C = new int[a_rows, b_cols];
    for (int i = 0; i < a_rows; i++)
    {
        for (int j = 0; j < b_cols; j++)
        {
            for (int k = 0; k < a_cols; k++)
            {
                C[i,j] += A[i,k]*B[k,j];
            }
        }
    }
    return C;
}

int m1 = 3; // количество строк матрицы А
int n1 = 2; // количество столбцов матрицы А
int m2 = 2; // количество строк матрицы В
int n2 = 1; // количество столбцов матрицы В
int[,] A = new int[m1, n1];
int[,] B = new int[m2, n2];
if (!IsMatrixCompatible(A,B))
{
    System.Console.WriteLine("Матрицы несовместимы!");
    return;
}
Fill2Array(A);
Fill2Array(B);
Print2ArrayConsole(A);
System.Console.WriteLine();
System.Console.WriteLine("X");
System.Console.WriteLine();
Print2ArrayConsole(B);
System.Console.WriteLine();
System.Console.WriteLine("=");
System.Console.WriteLine();
Print2ArrayConsole(MultiMatrix(A,B));
