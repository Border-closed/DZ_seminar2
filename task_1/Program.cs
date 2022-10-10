Console.WriteLine("ВВедите трехзначное число:   ");
int A = int.Parse (Console.ReadLine());
int first = (A / 100);
int third = A % 10;
int second = (A - first*100 - third)/10;
Console.WriteLine (second);