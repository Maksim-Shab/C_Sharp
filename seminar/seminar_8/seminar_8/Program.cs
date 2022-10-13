// seminar_8

int name = 3;

switch(name) {

    case(1):
    // Задайте двумерный массив. Напишите программу,
    // которая заменяет строки на столбцы. В случае,
    // если это невозможно, программа должна вывести сообщение для пользователя.
    // 923     942
    // 424     226
    // 267     347

    Console.Clear();

    Console.Write("Введите кол-во строк: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кол-во столбцов: ");
    int column = Convert.ToInt32(Console.ReadLine());
    int[,] array = FillArray(row, column);
    PrintArray(array);
    Console.WriteLine();
    NewArray(array);
    // PrintArray(array);

    int[,] FillArray(int rows, int columns) {
        int[,] fillArray = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                fillArray[i, j] = new Random().Next(1, 10);
            }
        } 
        return fillArray;
    }

    void PrintArray(int[,] array) {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(" " + array[i, j]);
            }
            Console.WriteLine();
        }
    }
    void NewArray(int[,] array){
        if(row == column){
            int j = 0;
            for (int i = 0; i < row; i++)
            {
                j = i;
                while (j < column)
                {
                int n = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = n;
                j++;
                }        
            }
            PrintArray(array);
        } else {
            Console.WriteLine("Невозможно заменить строки на столбцы, так как они имеют разную длину.");
            Console.WriteLine();
        }
    }

    break;

    case(2):
    // Составить частотный словарь элементов двумерного массива.
    // Частотный словарь содержит информацию о том,
    // сколько раз встречается элемент входных данных.
    // 1 встречается 3 раза
    // 2 встречается 2 раз
    // 3 встречается 1 раз
    // 4 встречается 1 раз
    // 6 встречается 2 раза

    Console.Clear();

    int[,] array1 = FillArray(4, 4);
    PrintArray(array1);
    Console.WriteLine();

    int[] lineArray = new int[array1.GetLength(0) * array1.GetLength(1)];
    int g = 0;
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            lineArray[g] = array1[i,j];
            g++;
        }
    }

    Array.Sort(lineArray);
    Console.WriteLine("[" + String.Join(",", lineArray) + "]");
    int h = 1;
    int num = lineArray[0];
    for (int i = 1; i < lineArray.Length; i++)
    {
        if(num != lineArray[i]){
            Console.WriteLine(num + " встречается " + h + " раз");
            num = lineArray[i];
            h = 1;
        } else {
            h++;
        }
        
    }
    Console.WriteLine(num + " встречается " + h + " раз");

    break;

    case(3):
    // Задайте двумерный массив из целых чисел. Напишите программу,
    // которая удалит строку и столбец, на пересечении
    // которых расположен наименьший элемент массива.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // 5 2 6 7
    // Наименьший элемент - 1, на выходе получим
    // следующий массив:
    // 9 2 3
    // 4 2 4
    // 2 6 7

    Console.Clear();

    
    int[,] array3 = FillArray(4,4);
    PrintArray(array3);
    Console.WriteLine();
    PrintArray(NewArray1(array3));
    
    (int, int) MinNumberArray(int[,] array){
        int minNumber = array[0,0];
        int minIndexRow = 0;
        int minIndexColumn = 0;
        
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if(minNumber > array[i,j]){
                    minNumber = array[i,j];
                    minIndexRow = i;
                    minIndexColumn = j;
                }
            }
        }
        return (minIndexRow, minIndexColumn);
        
    }

    int[,] NewArray1(int[,] array) {
        int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
        int r = 0;
        int c = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (i == MinNumberArray(array).Item1)continue;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j == MinNumberArray(array).Item2)continue;
                newArray[r,c] = array[i,j];
                c++;
            }
            r++;
            c = 0;
        }
        return newArray;
    }   

    break;

}