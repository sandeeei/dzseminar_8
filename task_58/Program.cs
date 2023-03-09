// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] ferstArray=GetMatrix(3,2,0,10);
int[,] secondArray=GetMatrix(4,3,0,10);
Console.WriteLine($"\n Первый массив: \n");
PrintMatrix(ferstArray);
Console.WriteLine($"\n Второй массив: \n");
PrintMatrix(secondArray);
ComMatrix(ferstArray,secondArray);


/// <summary>
/// Метод произведения 2-х двумерных массивов
/// </summary>
/// <param name="matr1">Первый двумерный массив</param>
/// <param name="matr2">Второй двумерный массив</param>
/// <returns>Возврат array</returns>
int[,] ComMatrix(int[,] matr1, int[,] matr2)
{
    int[,] array = new int[matr1.GetLength(0), matr2.GetLength(1)];

    for (int i = 0; i < matr1.GetLength(0); ++i)
    {
        for (int j = 0; j < matr2.GetLength(0); ++j)
        {
            for (int k = 0; k < matr2.GetLength(1); ++k)
            {

                array[i, k] += matr1[i, j] * matr2[j, k];
            }
        }
    }

    return array;
}
/// <summary>
/// Заполнение двумерного массива рандомными элементами от min до max.
/// </summary>
/// <param name="rows">Количество строк</param>
/// <param name="cols">Количество столбцов</param>
/// <param name="minValue">Минимальное число для рандома</param>
/// <param name="maxValue">Максимальное число для рандома</param>
/// <returns></returns>
int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)

        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    return matrix;
}

/// <summary>
/// Метод печатает матрицу, которую передали на вход
/// </summary>
/// <param name="matr">Двумерный массив</param>
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int m = 0; m < matr.GetLength(1); m++)
        {
            Console.Write(matr[i, m] + "\t");
        }
        Console.WriteLine();
    }
}
