// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки 
// двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] resultMatrix = GetMatrix(5, 3, 0, 10);
PrintMatrix(resultMatrix);

ChangeRows(resultMatrix);
PrintMatrix(resultMatrix);


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

void ChangeRows(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {

        for (int j = 0; j < matr.GetLength(1); j++)
        {
            int temp;
            if (matr[i, j] < matr[i + 1, j])
            {
                temp = matr[i, j];
                matr[i,j]=matr[i+1,j];
                matr[i+1,j]=temp;

            }
        }
    }
}