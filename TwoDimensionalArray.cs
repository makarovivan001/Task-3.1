using System;
namespace HomeWork_Makarov_Ivan_number_3._1
{
	public class TwoDimensionalArray
	{
        private int[,] array;

        public TwoDimensionalArray(bool personGet, int length, int width)
        {
            Create(personGet, length, width);
        }
        public void Print()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");

                }
                Console.Write("\n");

            }
        }
        private int[,] PersonGet()
        {
            Console.Write("Введите длину: ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Введите ширину: ");
            int width = int.Parse(Console.ReadLine());
            int[,] array = new int[length, width];
            Console.WriteLine("Вводите значения: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return array;
        }
        private int[,] RandomGet(int length, int width)
        {
            Random random = new Random();
            int[,] array = new int[length, width];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    array[i, j] = random.Next(0, 10);
                }
            }
            return array;
        }
        public void Create(bool personGet, int length, int width)
        {
            if (personGet)
            {
                array = PersonGet();

            }
            else
            {
                array = RandomGet(length, width);
            }
        }

        public decimal GetAverage()
        {
            decimal summa = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    summa += array[i, j];
                }
            }
            return summa / array.Length;
        }
        public void PrintAsMatrix()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write($"{array[i, j]} ");
                    }
                    else
                    {
                        Console.Write($"{array[i, array.GetLength(1) - j - 1]} ");
                    }

                }
                Console.Write("\n");
            }


        }
    }
}

