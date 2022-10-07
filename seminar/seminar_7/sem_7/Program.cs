// seminar_7

int name = 5;

switch (name) {

    case(1):
    //Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
    //m = 3, n = 4.
    //1 4 8 19
    //5 -2 33 -2
    //77 3 8 1

    Console.Clear();

    Console.WriteLine("Введите количество строк двумерного массива");
    int rowCount = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите количество столбцов двумерного массива");
    int columnCount = int.Parse(Console.ReadLine());

    int[,] array = FillArray(rowCount, columnCount, -10, 10);
    PrintArray(array);

    int[,] FillArray(int rows, int columns, int min, int max)
    {
        int[,] filledArray = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                filledArray[i, j] = new Random().Next(min, max + 1);
            }
        }
        return filledArray;
    }

    void PrintArray(int[,] inputArray)
    {
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            for (int j = 0; j < inputArray.GetLength(1); j++)
            {
                Console.Write(" " + inputArray[i, j]);
            }
            Console.WriteLine();
        }
    }



    break;

    case(2):


    // Задайте двумерный массив размера m на n,
    // каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
    // Выведите полученный массив на экран.
    // m = 3, n = 4.
    // 0 1 2 3
    // 1 2 3 4
    // 2 3 4 5

    Console.Clear();

    Console.WriteLine("Введите количество строк двумерного массива");
    int rowCount1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите количество столбцов двумерного массива");
    int columnCount1 = int.Parse(Console.ReadLine());

    int[,] array1 = FillArray1(rowCount1, columnCount1);
    PrintArray1(array1);

    int[,] FillArray1(int rows, int columns)
    {
        int[,] filledArray = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                filledArray[i, j] = i + j;
            }
        }
        return filledArray;
    }

    void PrintArray1(int[,] inputArray)
    {
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            for (int j = 0; j < inputArray.GetLength(1); j++)
            {
                Console.Write(" " + inputArray[i, j]);
            }
            Console.WriteLine();
        }
    }


    break;
    
    case(3):

    // Задайте двумерный массив. Напишите программу,
    // которая поменяет местами первую и последнюю строку массива.
    
    // Изначальный массив: 	        Итоговый массив:
    // 1 4 7 2                      8 4 2 4
    // 5 9 2 3                      5 9 2 3
    // 8 4 2 4                      1 4 7 2
    
    Console.Clear();
    Console.WriteLine("Введите количество строк: ");
    int rowCount2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов: ");
    int columnCount2 = Convert.ToInt32(Console.ReadLine());

    int[,] array2 = FillArray2(rowCount2, columnCount2, 1, 9);
    PrintArray2(array2);
    Console.WriteLine();
    Console.WriteLine("Измененный массив: ");
    NewFillArray2(array2);
    PrintArray2(array2);

    int[,] FillArray2(int rows, int columns, int min, int max) {
        int[,] fillArray = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                fillArray[i, j] = new Random().Next(min, max);
            }
        }
        return fillArray;
    }

    void PrintArray2(int[,] inputArray)
    {
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            for (int j = 0; j < inputArray.GetLength(1); j++)
            {
                Console.Write(" " + inputArray[i, j]);
            }
            Console.WriteLine();
        }
    }

    int[,] NewFillArray2(int[,] array2){
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            int k = array2[array2.GetLength(0) - 1, j];
            array2[array2.GetLength(0) - 1, j] = array2[0, j];
            array2[0, j] = k;
        }
        return array2;
    }
    break;

    case(4):
    // Задайте двумерный массив. Найдите элементы
    // у которых оба индекса чётные, и замените эти элементы
    // на их квадраты.

    // Например, изначально массив     Новый массив будет выглядеть
    // выглядел вот так:               вот так:         
    // 1 4 7 2                         1 4 49 2
    // 5 9 2 3                         5 9 2 4
    // 8 4 2 4                         64 4 4 4

    Console.Clear();

    Console.Write("Введите количчство строк: ");
    int rowCount3 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количчство столбцов: ");
    int columnCount3 = Convert.ToInt32(Console.ReadLine());
    int[,] array3 = FillArray2(rowCount3, columnCount3, 1, 9);
    PrintArray(array3);
    NewArray3(array3);
    Console.WriteLine();
    Console.WriteLine("Новый массив: ");
    PrintArray(array3);

    int[,] NewArray3(int[,] array3){
        for (int i = 0; i < rowCount3; i++)
        {
            for (int j = 0; j < columnCount3; j++)
            {
                if(i % 2 == 0 && j % 2 == 0) {
                    array3[i, j] = Convert.ToInt32(Math.Pow(array3[i, j], 2));    
                }
            }
        }    
        return array3;
    }

    break;

    case(5):
    // Задайте двумерный массив. Найдите сумму элементов, 
    // находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // Сумма элементов главной диагонали: 1+9+2 = 12

    Console.Clear();

    Console.Write("Введите количчство строк: ");
    int rowCount4 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количчство столбцов: ");
    int columnCount4 = Convert.ToInt32(Console.ReadLine());
    int[,] array4 = FillArray2(rowCount4, columnCount4, 1, 9);
    PrintArray(array4);
    Console.WriteLine("Сумма элементов по диагонали: ");
    
    int summ = 0;
    for (int i = 0; i < rowCount4; i++)
    {
        for (int j = 0; j < columnCount4; j++)
        {
            if(i == j) {
                summ += array4[i, j];
            }
        }
    }    
    Console.WriteLine(summ);
    

    break;
}