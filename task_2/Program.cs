Console.WriteLine("Введите число:   ");
string A = Console.ReadLine();
int length = A.Length;
if (length>2)
{
    string B = A.Substring (0,3);
    int C = int.Parse(B);
    int third = C % 10;
    Console.WriteLine (third);
}
else
{
    Console.WriteLine ("Третьей цифры нет (=введено число меньше 100)");
}