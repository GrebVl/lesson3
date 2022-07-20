/* программа принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

void FillArry(int[] array, int number)
{
    int length = array.Length;
    int i = 0;
    while (i < length)
    {
        array[i] = number % 10;
        number = number / 10;
        i++;
    }
}

void Palin(int[] arr)
{
    int count = arr.Length;
    int j = 0;
    string pal = "";
    while (j < count)
        if (arr[j] == arr[count - 1])
        {
            pal = "Данное число является пфлиндромом";
            j++;
            count--;
        }
        else
        {
            pal = "Данное число не является пфлиндромом";
            break;
        }
    Console.WriteLine(pal);
}

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());

int[] arry = new int[5];

FillArry(arry, num);

Palin(arry);


