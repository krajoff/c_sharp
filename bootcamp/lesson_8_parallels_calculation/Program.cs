const int N = 1001; // размер матрицы
const int THREADS_NUMBER = 8; // количество потоков

int[,] serialMulResult = new int[N, N];
int[,] threadMulResult = new int[N, N];

int[,] firstMatrix = MatrixGenerator(N, N);
int[,] secondMaxtrix = MatrixGenerator(N, N);

SerialMatrixMul(firstMatrix, secondMaxtrix);
PrepareParallelMatrixMul(firstMatrix, secondMaxtrix);


int[,] MatrixGenerator(int rows, int columns)
{
    Random _rand = new Random();
    int[,] res = new int[rows, columns];
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            res[i, j] = _rand.Next(-100, 100);

        }
    }
    return res;
}

void SerialMatrixMul(int[,] a, int[,] b)
{
    if (a.GetLength(1) != b.GetLength(0)) throw new Exception("No reason to multiply");
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                serialMulResult[i, j] += a[i, k] * b[k, j];
            }
        }
    }
}

void PrepareParallelMatrixMul(int[,] a, int[,] b)
{
    if (a.GetLength(1) != b.GetLength(0)) throw new Exception("No reason to multiply");
    int eachTreadCalc = N / THREADS_NUMBER;
    var threadsList = new List<Thread>();
    for (int i = 0; i < THREADS_NUMBER; i++)
    {
        int startPosition = i * eachTreadCalc;
        int endPosition = (i + 1) * eachTreadCalc;
        // если поток уже последний
        if (i == THREADS_NUMBER - 1) endPosition = N;
        threadsList.Add(new Thread(() => ParallelMatrixMul(a, b, startPosition, endPosition)));
        threadsList[i].Start();
    }
    for (int i = 0; i < THREADS_NUMBER; i++)
    {
        threadsList[i].Join();
    }
}

void ParallelMatrixMul(int[,] a, int[,] b, int startPosition, int endPosition)
{
    for (int i = startPosition; i < endPosition; i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                threadMulResult[i, j] += a[i, k] * b[k, j];
            }
        }
    }
}