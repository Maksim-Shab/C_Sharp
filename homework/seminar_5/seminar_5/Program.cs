// seminar_5

int name = 39;

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

    // // Задайте массив вещественных чисел.
    // // Найдите разницу между максимальным и минимальным элементов массива.
    // // [3 7 22 2 78] -> 76

    Console.Clear();

    double[] array2 = new double[4];
    double max = -int.MaxValue;
    double min = int.MaxValue;
  
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
    
    FillArray2(array2);
    Console.WriteLine("Получился мыссив: " + "[" + String.Join(",", array2) + "]");
    MaxElement(array2);
    MinElement(array2);
    System.Console.WriteLine(max + " " + min);
    Console.WriteLine("Разница между максимальным и минимальным элементами массива является: " + (max - min));

    break;

    case(39):
    // Задайте одномерный массив, заполненный случайными числами.
    // Из входного массива сформируйте массив с чётными
    // и массив с нечётными значениями элементов входного массива.
    // Найдите ср. арифметическое из полученных значений элементов массивов
    // и выведите результат сравнения средних арифметических.
    // [1,2,3,4] -> средн. арифм. значений элементов массива 
    // с чётными числами > средн. арифм. значений элементов с нечётными числами
    // [2,3,5,7] -> средн. арифм. массива значений элементов
    // с нечётными числами > средн. арифм. значений элементов с чётными числами
    // [1,2,5,4] -> средн. арифм. значений элементов массива
    // с нечётными числами = средн. арифм. значений элементов с чётными числами

    Console.Clear();

    int[] array3 = NewArray();

    int[] NewArray(){
        int[] newArray = new int[8];
        for (int i = 0; i < newArray.Length; i++)
        {
            newArray[i] = new Random().Next(1, 9);
        }
        return newArray;
    }

    double SrednArifmArray(int[] array) {
        double srednArifmArray = 0;
        for (int i = 0; i < array.Length; i++)
        {
            srednArifmArray += array[i];
        }
        srednArifmArray = Math.Round(srednArifmArray  / array.Length, 2);
        return srednArifmArray;
    }
    
    int[] chetArray = new int[1];
    int[] nechArray = new int[1];
    int j = 0;
    int l = 0;
    for (int i = 0; i < array3.Length - 1; i++)
    {
        if(array3[i] % 2 != 0) {
            nechArray[j] = array3[i];
            Array.Resize(ref nechArray, nechArray.Length + 1);
            j++;
        }
        else {
            chetArray[l] = array3[i];
            Array.Resize(ref chetArray, chetArray.Length + 1);
            l++;
        }
    }
    Array.Resize(ref chetArray, chetArray.Length - 1);
    Array.Resize(ref nechArray, nechArray.Length - 1);


    Console.WriteLine("Исходный массив: " + "[" + String.Join(",", NewArray()) + "]");   
    Console.WriteLine("Массив из нечетных значений: "
        + "[" + String.Join(",", nechArray) + "] - "
        + "среднее арифметическое: " + SrednArifmArray(nechArray));
    Console.WriteLine("Массив из четных значений: "
        + "[" + String.Join(",", chetArray) + "] - "
        + "среднее арифметическое: " + SrednArifmArray(chetArray));

    if(SrednArifmArray(nechArray) == SrednArifmArray(chetArray)){
        Console.WriteLine("Средн. арифм. четного массива = нечетному");
    } else if(SrednArifmArray(nechArray) < SrednArifmArray(chetArray)){
        Console.WriteLine("Средн. арифм. четного массива > нечетного");
    } else {
        Console.WriteLine("Средн. арифм. четного массива < нечетного");
    }

    break;
}