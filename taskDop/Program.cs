/*
программа для вычисления площади круга, прямоугольника и треугольника. 
Ввод данных осуществляется в диалоговом режиме. На первом шаге 
у пользователя запрашивается фигура, площадь которой нужно вычислить.
На втором шаге пользователь вводит параметры, необходимые для рассчета. 
Затем, выводится результат.
*/

Console.WriteLine("ведите номер фигуры площадь которой необходимо вычислить:"
+ "\n 1. Круг \n 2. Прямоугольник \n 3. Треугольник");
int num = int.Parse(Console.ReadLine());

if (num == 1)
{
    Console.WriteLine("Выберете, что известно(Введите номер):"
                     + "\n 1.Радиус \n 2. Длина");
    int circle = int.Parse(Console.ReadLine());
    double PI = 3.14;
    double squareCir = 0;
    if (circle == 1)
    {
        Console.WriteLine("ведите радиус");
        int radiusCircle = int.Parse(Console.ReadLine());
        squareCir = PI * Math.Pow(radiusCircle, 2);
        Console.WriteLine("площадь круга равна = " + squareCir);
    }
    else if (circle == 2)
    {
        Console.WriteLine("ведите длину");
        int distnsCircle = int.Parse(Console.ReadLine());
        squareCir = Math.Pow(distnsCircle, 2) / (4 * PI);
        Console.WriteLine("площадь круга равна = " + squareCir);
    }
    else
    {
        Console.WriteLine("ошибка ввода");
    }

}
else if (num == 2)
{
    Console.WriteLine("ведите длину");
    int lengthRec = int.Parse(Console.ReadLine());
    Console.WriteLine("ведите ширину");
    int widthRec = int.Parse(Console.ReadLine());
    double squareRectangle = lengthRec * widthRec;
    Console.WriteLine("площадь прямоугольника равна = " + squareRectangle);
}
else if (num == 3)
{
    Console.WriteLine("ведите длину основания");
    int lengthTri = int.Parse(Console.ReadLine());
    Console.WriteLine("ведите высоту");
    int heightTri = int.Parse(Console.ReadLine());
    double squareTriangle = (lengthTri * heightTri) / 2;
    Console.WriteLine("площадь треугольника равна = " + squareTriangle);

}
else
{
    Console.WriteLine("ошибка ввода");
}