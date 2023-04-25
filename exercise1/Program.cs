//Программа принимающая на входе трехзначное
// число и показывающее на выходе вторую цифру

Console.Write("Введите трехзначное число: ");
int rand = int.Parse(Console.ReadLine());

TwoNumber(rand);

void TwoNumber(int x)
{
if(x<99)  Console.WriteLine("Число не трехзначное");
if(x>1000)  Console.WriteLine("Число не трехзначное");
else


{
    int ost = x % 100;
    int del = ost / 10;
    Console.WriteLine("Вторая цифра " +del);
}
}




