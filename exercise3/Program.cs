// Вадим цифру и программа говорит выходной это или нет
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int num1 = 0;


    if(num<1)
    {
         Console.WriteLine("Не корректное число");
    }
    else if(num>7)
    {
         Console.WriteLine("Не корректное число");
    }
    else if(num>5)
    {
      Console.Write(" -> Yes");
    }
    else
     {
        Console.Write(" -> No");
     }

