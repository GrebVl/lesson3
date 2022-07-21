/* 
программа принимает на вход число (N) и выдаёт таблицу кубов 
чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Ведите число N");
int N= int.Parse(Console.ReadLine());

if (N>0)
{
for (int i=1; i<N+1; i++)
{
    Console.Write(Math.Pow(i,3)+" ");
}
}
else
{
for (int i=-1; i>N-1; i--)
{
    Console.Write(Math.Pow(i,3)+" ");
}
}