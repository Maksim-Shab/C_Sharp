// seminar_5

int name = 38;

switch(name){

    case(34):
    // Задайте массив заполненный случайными положительными трёхзначными
    // числами. Напишите программу, которая покажет количество чётных
    // чисел в массиве.
    // [345, 897, 568, 234] -> 2
    
    Console.Clear();

    int[] array = new int[4];
    
    int[] FillArray(int[] array) {
        for (int i = 0; i < 4; i++)
        {
            array[i] = new Random().Next(100, 999);
        }
        return array;
    }
    
    int EvenNumbers(int[] array) {
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {        
            if((array[i] % 2) == 0) {
                j += 1; 
            }
        }
        return j;
    }

    FillArray(array);
    Console.WriteLine("Получился мыссив: " + "[" + String.Join(",", array) + "]");
    Console.WriteLine("Четных чисел в нём: " + EvenNumbers(array));
    
    break;

    case(36):
    // // Задайте одномерный массив, заполненный случайными числами.
    // // Найдите сумму элементов, стоящих на нечётных позициях.
    // // [3, 7, 23, 12] -> 19
    // // [-4, -6, 89, 6] -> 0

    Console.Clear();

    int[] array1 = new int[4];

    int[] FillArray1(int[] array1) {
        for (int i = 0; i < array1.Length; i++)
        {
            array1[i] = new Random().Next(-100, 100);    
        }
        return array1;
    }

    int SummArray1(int[] array1) {
        int summ = 0;
        for (int i = 0; i < array1.Length; i++)
        {
            if(i % 2 != 0) {
                summ = summ + array1[i];
            }
        }
        return summ;
    }

    FillArray1(array1);
    Console.WriteLine("Получился мыссив: " + "[" + String.Join(",", array1) + "]");
    Console.WriteLine("Cуммой элементов, стоящих на нечётных позициях является: " + SummArray1(array1));

    break;

    case(38):
                    // НЕ РАБОТАЕТ!!!!

    // // Задайте массив вещественных чисел.
    // // Найдите разницу между максимальным и минимальным элементов массива.
    // // [3 7 22 2 78] -> 76

    Console.Clear();

    double[] array2 = new double[4];
    double max = array2[0];
    double min = array2[0];
    double result2 = 0;

    double[] FillArray2(double[] array2) {
        for (int i = 0; i < array2.Length; i++)
        {
            array2[i] = new Random().Next(-100, 100);
        }
        return array2;
    }
    
    double MaxElement(double[] array2) {
        for (int i = 0; i < array2.Length; i++)
        {
            if(array2[i] > max) {
                max = array2[i];
            }
        }
        return max;
    }

    double MinElement(double[] array2) {
        for (int i = 0; i < array2.Length; i++)
        {
            if(min > array2[i]) {
                min = array2[i];
            }
        }
        return min;
    }
            // НЕ РАБОТАЕТ!!!!
    
    FillArray2(array2);
    Console.WriteLine("Получился мыссив: " + "[" + String.Join(",", array2) + "]");
    MaxElement(array2);
    MinElement(array2);
    System.Console.WriteLine(max + " " + min);
    Console.WriteLine("Разница между максимальным и минимальным элементами массива является: " + (max - min));

    break;
}