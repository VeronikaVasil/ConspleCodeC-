/* Создание двумерного массива */

Console.Write("Введите число срок:  ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбиков:  ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,]GetArray (int m, int n)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(-99,100);
        }
    }
    return matrix;
}
 double[,] result = GetArray(rows, columns);
 void PrintArray (double[,]inputMatrix)
 {
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
      for (int m = 0; m < inputMatrix.GetLength(1); m++)
      {
        Console.Write(inputMatrix[i,m] + "\t"); // \t - Tab    
      }
      Console.WriteLine();
    }
 }
PrintArray (result);
