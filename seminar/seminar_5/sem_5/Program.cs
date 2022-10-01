// Seminar_5
Console.Clear();

    // Задача 31: Задайте массив из 12 элементов, заполненный случайными числами
    // из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
    //Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
    // сумма положительных чисел равна 29, сумма отрицательных равна -20.

    Console.Clear();

    int[] array = FillArray(12, -9, 9);

    int positiveSum = 0;
    int negativeSum = 0;

    Console.WriteLine("[" + String.Join(",",array)+ "]");

    foreach(int element in array){
        positiveSum += element > 0 ? element : 0; //positiveSum += element -> // positiveSum = element + positiveSum
        negativeSum += element < 0 ? element : 0;
    }

    Console.WriteLine("Положительные числа в массиве:" + positiveSum);
    Console.WriteLine("Отрицательные числа в массиве:" + negativeSum);


    int[] FillArray(int size, int min, int max)
    {
        int[] filledArray = new int[size];

        for (int i = 0; i < filledArray.Length; i++)
        {
            filledArray[i] = new Random().Next(min, max + 1);
        }
        return filledArray;
    }

        
                                // end         
                                        
                                // new


    // Общее обсуждение решения
    // Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
    // [-4, -8, 8, 2] -> [4, 8, -8, -2] 
    // Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
    // 4; массив [6, 7, 19, 345, 3] -> нет
    // 3; массив [6, 7, 19, 345, 3] -> да

    // Console.WriteLine("\nЗамена элементов массива на противоположный знак:\n");

    // int arr_length = 4;

    // int[] filledArray1 = FillArray(arr_length, -10, 10);
    // Console.WriteLine("\nРазмер массива:\n {0}", arr_length);
    // Console.WriteLine("\nИсходный массив: ");
    // PrintArray(filledArray1);
    // ChangeArr(filledArray1);
    // Console.WriteLine("\nИзмененный массив: ");
    // PrintArray(filledArray1);

    // int[] FillArray(int size, int min, int max)
    // {
    //     int[] filledArray = new int[size];

    //     for (int i = 0; i < filledArray.Length; i++)
    //     {
    //         filledArray[i] = new Random().Next(min, max + 1);
    //     }
    //     return filledArray;
    // }

    // void PrintArray(int[] arr)
    // {
    //     Console.WriteLine("\n [" + String.Join(",", arr) + "]");
    // }

    // void ChangeArr(int[] arr)
    // {
    //     for (int i = 0; i < arr.Length; i++)
    //     {
    //         arr[i] = - arr[i];
    //     }
    // }



                // Вариант 2

    // Console.WriteLine("\nПоиск числа в массиве:\n");

    // int arr_length = 5;

    // Console.WriteLine("\nВведите число: ");
    // int num  = Convert.ToInt32(Console.ReadLine());

    // int[] filledArray1 = FillArray(arr_length, -10, 10);

    // Console.WriteLine("\nМассив: ");
    // PrintArray(filledArray1);
    // Console.WriteLine(SearchNum(filledArray1, num) ? "\n Да" : "\n Нет");

    // int[] FillArray(int size, int min, int max)
    // {
    //     int[] filledArray = new int[size];

    //     for (int i = 0; i < filledArray.Length; i++)
    //     {
    //         filledArray[i] = new Random().Next(min, max + 1);
    //     }
    //     return filledArray;
    // }

    // void PrintArray(int[] arr)
    // {
    //     Console.WriteLine("\n [" + String.Join(",", arr) + "]");
    // }

    // bool SearchNum(int[] arr, int search_num)
    // {
    //     for (int i = 0; i < arr_length; i++)
    //     {
    //         if (arr[i] == num)
    //         {
    //             return true;
    //         }
    //     }    
    //     return false;
    // }


                            // end



                            // new

// Console.WriteLine("\nПоиск числа в массиве:\n");

// int arr_length = int.Parse(Console.ReadLine());

// int[] filledArray1 = FillArray(arr_length, 1, 123);

// Console.WriteLine("\nМассив: ");
// PrintArray(filledArray1);
// Console.WriteLine(SearchNum(filledArray1));

// int[] FillArray(int size, int min, int max)
// {
//     int[] filledArray = new int[size];

//     for (int i = 0; i < filledArray.Length; i++)
//     {
//         filledArray[i] = new Random().Next(min, max + 1);
//     }
//     return filledArray;
// }

// void PrintArray(int[] arr)
// {
//     Console.WriteLine("\n [" + String.Join(",", arr) + "]");
// }

// int SearchNum(int[] arr)
// { int count = 0;

//     for (int i = 0; i < arr_length; i++)
//     {
//         if (arr[i] >= 10 && arr[i] <= 99)
//         {
//             count ++;
//         }

//     }    
//     return count;
// }



                            // end


                            // new














// }int arr_length = 12;

// Console.WriteLine("\nМассив из {0} элементов:\n", arr_length);

// Random random = new Random();
// int[] arr = new int[arr_length];
// int pos_num = 0;
// int neg_num = 0;

// for (int i = 0; i < arr_length; i++)
// {
//     arr[i] = random.Next(-9, 9);
//     Console.Write(arr[i] + " ");
// }

// for (int i = 0; i < arr_length; i++)
// {
//     if (arr[i] > 0)
//     {
//         pos_num = pos_num + arr[i];
//     }
//     else
//     {
//         neg_num = neg_num + arr[i];
//     }
// }

// Console.WriteLine("\nСумма положительных элементов: {0}", pos_num);
// Console.WriteLine("\nСумма отрицательных элементов: {0}", neg_num);
