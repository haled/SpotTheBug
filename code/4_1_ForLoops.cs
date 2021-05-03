using System;

namespace ForLoops
{
    public static class MatrixAdder
    {
        public static int[,] AddTwoMatrices(int[,] matrix1, int[,] matrix2)
        {
            int[,] additionResult = new int[2,2];

            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    additionResult[j,i] = matrix1[i,j] + matrix2[i,j];
                }
            }

            return additionResult;
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine("{0} {1}", matrix[i,0], matrix[i,1]);
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            int[,] matrix1 = { {1,0}, {3,8} };
            int[,] matrix2 = { {2,5}, {4,7} };

            int[,] result = MatrixAdder.AddTwoMatrices(matrix1, matrix2);

            MatrixAdder.PrintMatrix(result);
        }
    }
}
