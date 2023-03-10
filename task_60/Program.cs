// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся
//  двузначных чисел. Напишите программу, которая будет построчно
//   выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] threeMatrix = GetMatrix(2, 2, 2);
PrintMatrix(threeMatrix);

/// <summary>
/// Метод заполняет трёхмерный массив
/// </summary>
/// <param name="rows">Число строк</param>
/// <param name="cols">Число столбцов</param>
/// <param name="depth">Число глубины</param>
/// <returns></returns>
int[,,] GetMatrix(int rows, int cols, int depth)
{
    int[,,] matrix = new int[rows, cols, depth];
    for (int i = 0; i < rows; i++)

        for (int j = 0; j < cols; j++)
        {
            for (int m = 0; m < depth; m++)
            {
                matrix[i, j, m] = new Random().Next(10, 100);
            }

        }

    return matrix;
}

/// <summary>
/// Метод построчно выводит элементы массива при этом ечатая его индексы
/// /// </summary>
/// <param name="matr">Двумерный массив</param>
void PrintMatrix(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {

            for (int m = 0; m < matr.GetLength(2); m++)
            {
                Console.Write($"\n {matr[i, j, m]}  ({i},{j},{m}) \t");
            }

        }
    }

}