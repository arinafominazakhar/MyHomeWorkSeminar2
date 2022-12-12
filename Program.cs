// Домашняя работа. Семинар 2
// Задача 1 (10) Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int CutNumber(int num)
{
    int ten = num / 10;
    int ed = ten % 10;

    return ed;
}

Console.WriteLine("Напишите трехзначное число: ");
int yourNum = Convert.ToInt32(Console.ReadLine());
int newNum = CutNumber(yourNum);
Console.WriteLine($"{yourNum} и {newNum}");
*/


// Задача 2 (13) Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
int TrirdNum(int num)
{
    while(num > 1000)
        {
            num = num / 10;
        }
    int a = num % 10;
    return a;
}

Console.WriteLine("Введите любое число: ");
int b = Convert.ToInt32(Console.ReadLine());

if(b >= 100)
{
    Console.WriteLine(TrirdNum(b));
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
*/

// Задача 3 (15) Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool dayNum (int num)
{
    if (num > 5)
    {
        return true;
    }
    
    else
    {
        return false;
    }
}

Console.WriteLine("Введите число от 1 до 7, обозначающее день недели чтобы узнать является ли этот день выходным: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(dayNum(a));
*/