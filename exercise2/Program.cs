// Программа выводящая третью цифру числа

int rand = new Random().Next(1, 100000);
Console.WriteLine("Наше число " + rand);
if(rand > 99 & rand <999)
{
   rand = rand / 10;
   Console.WriteLine("Третья цифра: " + rand);
}
 if(rand >999 & rand < 9999)
{
    rand = rand / 10;
    Console.WriteLine("Третья цифра: " + rand%10);
}
else if(rand > 9999)
{
 rand = rand / 100;
    Console.WriteLine("Третья цифра: " + rand%10);

}
else
{
    Console.WriteLine("Третьей цифры нет");
}
