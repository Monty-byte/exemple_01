Console.Clear(); // очистка консоли
//Console.SetCursorPosition(10, 4); // отступ от левого края и от верхнего (рисует)
//Console.WriteLine("+");

int xa = 40, ya = 1, // вершина треугольника
    xb = 1, yb = 30, // один из вариантов записи
    xc = 80, yc = 30;


Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb;  // определение случайной точки

int count = 0; // счетчик

while (count < 10000)
{
    int what = new Random().Next(0, 3); // выбирать одну из двух точек, определение случайного числа
    if (what == 0)
    {
        x = (x + xa)/2;
        y = (y + ya)/2;
    }
    if (what == 1)
    {
        x = (x + xb)/2;
        y = (y + yb)/2;
    }
    if (what == 2)
    {
        x = (x + xc)/2;
        y = (y + yc)/2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count += 1;
}