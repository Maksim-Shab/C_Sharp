// seminar_7
 int name = 50;

 switch(name){

    case(47):

    // Задайте двумерный массив размером m×n,
    // заполненный случайными вещественными числами.
    // m = 3, n = 4.
    // 0,5 7 -2 -0,2
    // 1 -3,3 8 -9,9
    // 8 7,8 -7,1 9

    Console.Clear();

    System.Console.Write("Введите количество строк: ");
    int rowCount = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите количество столбцов: ");
    int columnCount = Convert.ToInt32(Console.ReadLine());
    double[,] array = FillArrayDouble(rowCount, columnCount);
    PrintArray(array);

    double[,] FillArrayDouble(int rows, int columns) {
        double[,] fillArray = new double[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                fillArray[i, j] = new Random().NextDouble();
            }
        }
        return fillArray;
    }
    
     void PrintArray(double[,] inputArray)
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

    case(50):

    // Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
    // и возвращает значение этого элемента или же указание, что такого элемента нет.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // 17 -> такого числа в массиве нет

    Console.Clear();
    
    System.Console.Write("Введите индекс строки: ");
    int rowIndex = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите индекс столбца: ");
    int columnIndex = Convert.ToInt32(Console.ReadLine());
    int[,] array2 = FillArray(6,9);
    System.Console.WriteLine("Полученный массив: ");
    PrintArray1(array2);
    if(0 <= rowIndex && rowIndex < array2.GetLength(0) 
        && 0 <= columnIndex && columnIndex < array2.GetLength(1)){
            System.Console.WriteLine("Результатом введенных индексов является: " + array2[rowIndex, columnIndex]);
            System.Console.WriteLine();
    } else {
        System.Console.WriteLine("Такого числа в массиве нет!");
    }
    
    int[,] FillArray(int rows, int columns) {
        int[,] fillArray = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                fillArray[i, j] = new Random().Next(1,9);
            }
        }
        return fillArray;

    }
    
    void PrintArray1(int[,] inputArray) {
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            for (int j = 0; j < inputArray.GetLength(1); j++)
            {
                System.Console.Write(" " +  inputArray[i, j]);    
            }
            System.Console.WriteLine();
        }
    }

    break;
    
    case(52):

    // Задайте двумерный массив из целых чисел.
    // Найдите среднее арифметическое элементов в каждом столбце.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



    break;

 }
