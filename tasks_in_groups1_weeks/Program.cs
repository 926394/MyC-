// Задача №3. Напишите программу, которая будет
// выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите номер дня недели: ");
int num = int.Parse(Console.ReadLine()!);


if (num == 1)
{
    Console.WriteLine("Ответ: Понедельник" ); 
}
if (num == 2)
{
    Console.WriteLine("Ответ: Вторник" ); 
}
if (num == 3)
{
    Console.WriteLine("Ответ: Среда" ); 
}
if (num == 4)
{
    Console.WriteLine("Ответ: Четверг" ); 
}
if (num == 5)
{
    Console.WriteLine("Ответ: Пятница" ); 
}
if (num == 6)
{
    Console.WriteLine("Ответ: Суббота" ); 
}
if (num == 7)
{
    Console.WriteLine("Ответ: Воскресенье" ); 
}