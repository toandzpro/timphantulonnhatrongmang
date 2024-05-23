using System;
using System.Text;

public class Baitap19
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int[,] matrix = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };
        int max = matrix[0, 0];
        int row = 0, col = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                    row = i;
                    col = j;
                }
            }
        }
        Console.WriteLine($"Giá trị lớn nhất trong ma trận là {max} tại tọa độ [{row}, {col}].");
    }
}



