Console.Clear();

Console.WriteLine("Введите номер дня недели: ");

int numWeekday = int.Parse(Console.ReadLine());

if(numWeekday == 1) {
    Console.WriteLine("Понедельник");
}
else if(numWeekday == 2) {
    Console.WriteLine("Вторник");
}
else if(numWeekday == 3) {
    Console.WriteLine("Среда");
}
else if(numWeekday == 4) {
    Console.WriteLine("Четверг");
}
else if(numWeekday == 5) {
    Console.WriteLine("Пятница");
}
else if(numWeekday == 6) {
    Console.WriteLine("Суббота");
}
else if(numWeekday == 7) {
    Console.WriteLine("Воскресенье");
}
else {
    Console.WriteLine("Введи число от 1 до 7 ! Попробуй ещё раз.");
}