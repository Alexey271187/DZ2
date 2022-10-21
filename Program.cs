//Напишите программу, которая 
//принимает на вход трёхзначное число и 
Console.WriteLine("Впишите трехзначное число");
int numberA = int.Parse(Console.ReadLine()!);
//на выходе показывает вторую цифру этого числа. 
int SearchSecondNumber(int numberA)
{
if(numberA > 99)
    {
        if(numberA < 1000)
        {
            int numberB = numberA / 10 % 10;
            return numberB;
        }
        else Console.WriteLine("Вы ввели не трехзначное число");
        return numberA;
    }
else Console.WriteLine("Вы ввели не трехзначное число");
return numberA;
}

int numberB = SearchSecondNumber(numberA);

Console.WriteLine(numberB);