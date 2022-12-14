Console.WriteLine("введите число");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i<=N)
{
Console.Write($" {Math.Pow(i,3)}");
i=i+1;
}