Console.Clear();
Console.Write("Введите число квадрат: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Введи число, которое в квадрате выдаст первое число: ");
int number2 = int.Parse(Console.ReadLine());
if(number / number2 == number2)
{
    Console.WriteLine($"Всё верно!!! Квадратный корень числа {number} равен {number2}");
}
else{
    Console.WriteLine($"Попробуй ещё раз!");
}
