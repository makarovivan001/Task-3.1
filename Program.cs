using System;
using HomeWork_Makarov_Ivan_number_3;
using HomeWork_Makarov_Ivan_number_3._1;

class program
{
    static void Main(string[] args)
    {
        bool personGet;
        Console.WriteLine("Одномерный массив");
        Console.WriteLine("Вы введёте массив с клавиатуры?:  да/нет");
        personGet = personChoose();
        static bool personChoose()
        {
            bool personschoose = false;
            bool correct_or_incorrect_answer_is_incorrect = true;
            string input;
            while (correct_or_incorrect_answer_is_incorrect)
            {
                input = Console.ReadLine();
                if (input == "да")
                {
                    personschoose = true;
                    correct_or_incorrect_answer_is_incorrect = false;
                }
                else if (input == "нет")
                {
                    personschoose = false;
                    correct_or_incorrect_answer_is_incorrect = false;
                }
                else
                {
                    Console.WriteLine("Ответ некорректен, ответьте по-другому");    
                }
            }
            return personschoose;
        }
        OneDimensionalArray onedimensionalarray = new OneDimensionalArray(4, personGet);
        onedimensionalarray.Print();
        Console.WriteLine("Среднее значение элементов одномерного массива:");
        Console.WriteLine(onedimensionalarray.GetAverage());
        onedimensionalarray.DeliteElementsBigger100();
        Console.WriteLine("Произошло удаление элементов массива, больших 100 по модулю");
        onedimensionalarray.Print();
        onedimensionalarray.Delite_WhoRepeat();
        Console.WriteLine("Произошло удаление повторяющихся элементов массива");
        onedimensionalarray.Print();
        Console.WriteLine("Хотите пересоздать массив? да/нет");
        bool restart;
        restart = personChoose();
        if (restart)
        {
            Console.WriteLine("Вы введёте массив с клавиатуры?:  да/нет");
            personGet = personChoose();
            onedimensionalarray.Create(4, personGet);
            Console.WriteLine("Массив пересоздан");
            onedimensionalarray.Print();
        }
        Console.WriteLine("\n Двумерный массив:");
        Console.WriteLine("Вы введёте массив с клавиатуры?:  да/нет");
        personGet = personChoose();
        TwoDimensionalArray twodimensionalArray = new TwoDimensionalArray(personGet, 4, 5);
        twodimensionalArray.Print();
        Console.WriteLine("Среднее значение элементов двумерного массива:");
        Console.WriteLine(twodimensionalArray.GetAverage());
        Console.WriteLine("Матрица в обратном порядке четных строк:");
        twodimensionalArray.PrintAsMatrix();
        Console.WriteLine("Хотите пересоздать массив? да/нет");
        bool restart_1;
        restart_1 = personChoose();
        if (restart_1)
        {
            Console.WriteLine("Вы введёте массив с клавиатуры?:  да/нет");
            personGet = personChoose();
            twodimensionalArray.Create(personGet,4,5);
            Console.WriteLine(" Двумерный массив пересоздан");
            twodimensionalArray.Print();
            

        }
        Console.WriteLine("\nСтупенчатый массив:");
        Console.WriteLine("Вы введёте массив с клавиатуры?:  да/нет");
        personGet = personChoose();
        SteppedArray steppedarray = new SteppedArray(personGet, 4);
        steppedarray.Print();
        Console.WriteLine("Среднее значение элементов всего ступенчатого массива:");
        Console.WriteLine(steppedarray.GetAverage());
        Console.WriteLine("Средние значения во всех вложенных массивах:");
        Console.WriteLine(steppedarray.GetAverageValueFromArraysInSteppedArray());
        Console.WriteLine("Изменение всех четных по значению элементов массива на произведения их индексов:");
        steppedarray.Change();
        steppedarray.Print();
        Console.WriteLine("Хотите пересоздать массив? да/нет");
        bool restart_2;
        restart_2 = personChoose();
        if (restart_2)
        {
            Console.WriteLine("Вы введёте массив с клавиатуры?:  да/нет");
            personGet = personChoose();
            steppedarray.Create(personGet, 4);
            Console.WriteLine("Ступенчатый массив пересоздан");
            steppedarray.Print();
            
        }
        Console.ReadKey();
            







    }
}


        