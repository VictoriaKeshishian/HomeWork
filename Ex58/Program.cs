// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int firstLine = InputNumbers("Введите количество строк 1 матрицы: ");
int firstColumn = InputNumbers("Введите количество столбцов 1 матрицы (и строк второй матрицы): ");
int secondColumn = InputNumbers("Введите количество столбцов 2 матрицы: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

int [,] firstMatrix = new int[firstLine, firstColumn];
CreateArray(firstMatrix);
Console.WriteLine($"Первая матрица");
printArray(firstMatrix);

int [,] secondMatrix = new int[firstColumn, secondColumn];
CreateArray(secondMatrix);
Console.WriteLine($"Вторая матрица");
printArray(secondMatrix);

int [,] finalMatrix = new int[firstLine,secondColumn];


MatrixProduct(firstMatrix, secondMatrix, finalMatrix);
Console.WriteLine($"Произведение двух матриц:");
printArray(finalMatrix);

MatrixProduct(firstMatrix, secondMatrix, finalMatrix);
void MatrixProduct(int [,] firstMatrix, int [,] secondMatrix, int [,] finalMatrix)
{
    for (int i = 0; i < finalMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < finalMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                sum += firstMatrix[i,k] * secondMatrix[k,j];
            }
            finalMatrix[i,j] = sum;

        }
    }
}


int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int [,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void printArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j]+ " ");
    }
Console.WriteLine();
}
}
