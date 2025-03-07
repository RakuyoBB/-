﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ИСРПО_Практ_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ввод размерностей матрицы n и m
            Console.WriteLine("Введите количество строк:");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Введите количество столбцов:");
                if (int.TryParse(Console.ReadLine(), out int m))
                {

                    double[,] matrix = SozdMatr(n, m);

                }
                else { Console.WriteLine("Неверный ввод"); }
            }
            else { Console.WriteLine("Неверный ввод"); }
            Console.ReadKey();
        }
        static double[,] SozdMatr(int n, int m)
        {
            int polozElem = 0; //значение для положительных элементов
            double[,] matrix = new double[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = Math.Sin((i + j) / 2);
                    Console.Write(matrix[i, j]);

                    if (matrix[i, j] > 0)
                    {
                        polozElem++;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Количество положительных элементов в матрице:" + polozElem);
            return matrix;
        }
    }
}


