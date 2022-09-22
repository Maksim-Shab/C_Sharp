// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет,
// является ли этот день выходным.

Console.Clear();
Console.WriteLine("Введите номер дня недели: ");
string [] weekDay = {"Понедельник","Вторник","Среда","Четверг","Пятница","Суббота","Воскресенье"};
int number = int.Parse(Console.ReadLine());
if(0 < number && number < 8) {
    int i = number - 1;
    Console.WriteLine(weekDay[i]);
} 
else {
    Console.Write("Введи значение от 1 до 7 !!!");
}
if(number == 6 || number == 7) {
    Console.Write("Поздравляю!!! Это выходной день!!!");
}