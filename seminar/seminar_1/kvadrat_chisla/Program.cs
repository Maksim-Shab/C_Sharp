Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int result = number * number;
Console.WriteLine($"Квадрат числа {number} равен {result}");
Console.WriteLine($"Квадрат числа {number} равен {Math.Pow(number,2)}");