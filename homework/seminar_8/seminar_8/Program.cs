// seminar_8

int name = 58;

switch (name){

    case(54):

    // Задайте двумерный массив. Напишите программу,
    // которая упорядочит по убыванию элементы каждой строки двумерного массива.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // В итоге получается вот такой массив:
    // 7 4 2 1
    // 9 5 3 2
    // 8 4 4 2

    Console.Clear();

    int[,] array = FillArray(4, 4);
    Console.WriteLine("Исходный массив: ");
    PrintArray(array);
    Console.WriteLine();
    SortingArray(array);
    Console.WriteLine("Упорядоченный массив: ");
    PrintArray(array);

    int[,] FillArray(int rows, int columns){
        int[,] fillArray = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                fillArray[i, j] = new Random().Next(1, 9);
            }
        }
        return fillArray;
    }

    void PrintArray(int[,] array){
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(" " + array[i, j] );
            }
            Console.WriteLine();
        }
    }

    int[,] SortingArray(int[,] array) {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int g = 0; g < array.GetLength(1); g++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                { 
                    if(array[i,g] > array[i,j]){
                        int num = array[i, j];
                        array[i, j] = array[i,g];
                        array[i,g] = num;
                    }
                }
            }
        }
        return array;
    }

    break;

    case(56):
    // Задайте прямоугольный двумерный массив.
    // Напишите программу, которая будет находить строку с наименьшей суммой элементов.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // 5 2 6 7
    // Программа считает сумму элементов в каждой строке
    // и выдаёт номер строки с наименьшей суммой элементов: 1 строка

    Console.Clear();
    
    int[,] array1 = FillArray(4, 4);
    PrintArray(array1);
    MinNumberRow(array1);

    void MinNumberRow(int[,] array) {
        int min = 0 ;
        int numberRow = 1;
        for (int j = 0; j < array1.GetLength(1); j++)
            {
                min += array1[0 ,j];
            }
        for (int i = 1; i < array1.GetLength(0); i++)
        {
            int summ = 0;
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                summ += array1[i ,j];
            }
            if(min > summ) {
                min = summ;
                numberRow = i + 1;
            }
        }
        Console.WriteLine("Cтрока № " + numberRow + " имеет наименьшую сумму элементов, равную: " + min);
    }

    break;
    
    case(58):
    // Задайте две матрицы. Напишите программу,
    // которая будет находить произведение двух матриц.
    // Например, даны 2 матрицы:
    // 2 4 | 3 4
    // 3 2 | 3 3
    // Результирующая матрица будет:
    // 18 20
    // 15 18

    Console.Clear();

    int[,] firtMatrix = FillArray(2,2);
    Console.WriteLine("Матрица №1");
    PrintArray(firtMatrix);
    int[,] secondMatrix = FillArray(2,2);
    Console.WriteLine("Матрица №2");
    PrintArray(secondMatrix);
    Console.WriteLine("Результирующая матрица будет:");
    PrintArray(ProductTwoMatrix());

    int[,] ProductTwoMatrix(){
        int[,] productTwoMatrix = new int[2,2];
        for (int i = 0; i < firtMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < firtMatrix.GetLength(1); j++)
            {
                int summ = 0;
                for (int k = 0; k < firtMatrix.GetLength(1); k++)
                {
                    summ += firtMatrix[i ,k] * secondMatrix[k, j];
                }
                productTwoMatrix[i, j] = summ;
            }
        }
        return productTwoMatrix;
    }

    break;
    
}