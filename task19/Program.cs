Console.WriteLine("введите пятизначное число");
int N = Convert.ToInt32(Console.ReadLine());
if (N>=100000 || N<10000)
Console.WriteLine("введите именно пятизначное число");
else
{int [] pallindrom = new int [5];
for (int i = 4; i >= 0; i--) 
{
    pallindrom[i] = N % 10;
    N /= 10;
}
 if (pallindrom [0] == pallindrom [4])
 {
     if (pallindrom [1] == pallindrom [3])
     Console.WriteLine("да");
     else 
     Console.WriteLine("нет");
 }
else {
Console.WriteLine("нет");
}
}