using System;
namespace HomeWork_Makarov_Ivan_number_3._1
{
	public class SteppedArray
	{
        private int[][] array;
        public SteppedArray(bool personGet, int inputArray)
        {
            Create(personGet, inputArray);

        }
        private int[][] GetFromPerson()
        {


            Console.WriteLine("Введите количество ступеней массива: ");
            int inputArray = int.Parse(Console.ReadLine());
            int[][] array = new int[inputArray][];
            for (int i = 0; i < array.Length; i++)
            {

                Console.Write("Введите длину ступени массива: ");
                array[i] = new int[int.Parse(Console.ReadLine())];
                Console.WriteLine("Вводите значения массива: ");
                for (int j = 0; j < int.Parse(Console.ReadLine()); j++)
                {
                    array[i][j] = int.Parse(Console.ReadLine());
                }


            }
            return array;

        }
        private int[][] GetFromRandom(int inputArray)
        {
            Random random = new Random();
            int[][] array = new int[inputArray][];
            int length;
            for (int i = 0; i < inputArray; i++)
            {
                length = random.Next(2, 10);
                array[i] = new int[length];
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = random.Next(0, 10);
                }
            }
            return array;
        }
        public void Create(bool getfromperson, int inputArray)
        {
            if (getfromperson)
            {

                array = GetFromPerson();

            }
            else
            {
                array = GetFromRandom(inputArray);

            }
        }
        public decimal GetAverage()
        {
            int summa = 0;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    summa += array[i][j];
                    count++;

                }
            }
            return summa / count;
        }
        public decimal GetAverageValueFromArraysInSteppedArray()
        {
            decimal summa = 0;
            int counter = 0;
            double[] averages = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {

                int length = array[i].Length;
                int sum = array[i].Sum();
                counter += array[i].Length;
                for (int j = 0; j < array[i].Length; j++)
                {
                    summa += array[i][j];

                }

            }
            decimal result = summa / counter;


            return result;
        }
        public int[][] Change()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] % 2 == 0)
                    {
                        array[i][j] = i * j;
                    }
                }
            }
            return array;
        }
        public void Print()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write($"{array[i][j]}");
                }
            }
        }
    }
}

