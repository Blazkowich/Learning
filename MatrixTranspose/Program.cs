namespace MatrixTranspose;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix =
        {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };

        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);

        int[,] transpose = new int[col, row];

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                transpose[j, i] = matrix[i, j];
            }
        }

        Console.WriteLine("Standart Matrix");
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write(matrix[i,j] + " ");
            }
        }
        Console.WriteLine();

        Console.WriteLine("Transposed Matrix");
        for (int i = 0; i < col; i++)
        {
            for (int j = 0; j < row; j++)
            {
                Console.Write(transpose[i, j] + " ");
            }
        }

        for (int k = 0;k < row;k++)
        {
            Console.Write(transpose[k,k]);
        }
    }
}

