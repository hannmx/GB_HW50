using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_HW50
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.Write("Введите количетсво строк: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество столбцов: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[m, n];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(-100, 100);
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.Write("Введите индекс строки нужного элемента: ");
            int index_i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите индекс столбца нужного элемента: ");
            int index_j = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (index_i == i + 1)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (index_j == j + 1)
                        {
                            Console.WriteLine($"Значение [{index_i}, {index_j}] элемента массива: {matrix[i, j]}");
                        }
                    }
                }
                
            }
            if (index_i > matrix.GetLength(0) || index_j > matrix.GetLength(1))
            {
                Console.WriteLine("Указанного элемента в данном массиве нет!");
            }
        }
    }
}
