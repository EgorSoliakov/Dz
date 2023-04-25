// Программа выводящая третью цифру числа

int rand = new Random().Next(70, 120);
Console.WriteLine("Наше число " + rand);
if(rand > 99)
{
    int ost = rand % 10;
    Console.WriteLine("Третья цифра: " + ost);
}
else 
{
    Console.WriteLine("Третьей цифры нет");
}
