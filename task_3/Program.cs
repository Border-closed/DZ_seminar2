Console.WriteLine("Введите число от 1 до 7, обозначающее день недели:   ");
string A = Console.ReadLine();
try
{
int B = int.Parse(A);
if (B<0 || B>7)
{
    Console.WriteLine ("Вы ввели некорректное число. Введите число от 1 до 7, обозначающее день недели:   ");
}
    else if (B==6 || B==7)
    { 
        Console.WriteLine ("Это выходной");
    }
    else 
    {
        Console.WriteLine ("Это рабочий день");
    }
}
catch
{
    Console.WriteLine ("Вы ввели текст. Введите число от 1 до 7, обозначающее день недели:   ");
}