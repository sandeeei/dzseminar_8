// Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и
//  выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Изначальный массив
Console.WriteLine($"\n Заданый массив: \n");
int[,] resultMatrix = GetMatrix(6, 4, 0, 10);
PrintMatrix(resultMatrix);

SumMatrix(resultMatrix);


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

/// <summary>
/// Метод находит номер строки с наименьшим элементом
/// </summary>
/// <param name="matr">Двумерный массив</param>
void SumMatrix(int[,] matr)
{

    int index = 0;
    int minSum = int.MaxValue;

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i, j];

        }
        if (sum < minSum)
        {
            minSum = sum;
            index = i;

        }

    }

    Console.WriteLine($"\n Номер строки с наименьшей суммой элементов: {index + 1} \n");
}