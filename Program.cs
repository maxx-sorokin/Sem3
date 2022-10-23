Console.Clear();
Console.WriteLine("Введите номер задачи: 17, 18, 21 или 22");
int z = Convert.ToInt32(Console.ReadLine());



// // Задача 17 - Напишите программу, которая принимает на вход координаты точки (X и Y),
// // причём X не равно 0 и Y не равно 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

if (z == 17)
{
    Console.WriteLine("Введите координаты");
    bool isParsedX = int.TryParse(Console.ReadLine(), out int x);
    bool isParsedY = int.TryParse(Console.ReadLine(), out int y);

    if (!isParsedX || !isParsedY)
    {
        Console.WriteLine("Ошибка! Не правильо введены координаты");
        return;
    }

    int numberOfQuarter = DetermineNumberOfQuarter(x, y);

    if (numberOfQuarter == -1)
    {
        Console.WriteLine("Ошибка! Не правильо введены координаты");
    }
    else
    {
        Console.WriteLine($"{numberOfQuarter} четверть");
    }
}

// метод для задачи 17 - определяет в какой координатной четверти находится заданная точка

int DetermineNumberOfQuarter(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }
    if (x < 0 && y > 0)
    {
        return 2;
    }
    if (x < 0 && y < 0)
    {
        return 3;
    }
    if (x > 0 && y < 0)
    {
        return 4;
    }

    return -1;
}




// Задача 18 - Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

if (z == 18)
{
    Console.WriteLine("Введите номер четверти");
    bool isParsedQuarter = int.TryParse(Console.ReadLine(), out int quarter);

    if (!isParsedQuarter)
    {
        Console.WriteLine("Ошибка! Не правильно задана четверть");
        return;
    }
    string result = CoodinateOfQuarter(quarter);

    Console.WriteLine(result);
}

// метод для задачи 18 - по заданному номеру четверти, указывает диапазон возможных координат точек в этой четверти (x и y).

string CoodinateOfQuarter(int q)
{
    switch (q)
    {
        case 1:
            return "x > 0 и y > 0";
        case 2:
            return "x < 0 и y > 0";
        case 3:
            return "x < 0 и y < 0";
        case 4:
            return "x > 0 и y < 0";
        default:
            return "Ошибка! Не правильно задана четверть";
    }
}



// Задача 21 - Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

if (z == 21)
{
    Console.WriteLine("Введите координаты первой точки");
    bool isParsedXA = int.TryParse(Console.ReadLine(), out int xA);
    bool isParsedYA = int.TryParse(Console.ReadLine(), out int yA);

    Console.WriteLine("Введите координаты второй точки");
    bool isParsedXB = int.TryParse(Console.ReadLine(), out int xB);
    bool isParsedYB = int.TryParse(Console.ReadLine(), out int yB);

    if (!isParsedXA || !isParsedYA || !isParsedXB || !isParsedYB)
    {
        Console.WriteLine("Ошибка! Не правильо введены координаты");
        return;
    }

    double distanceDot = Distance(xA, yA, xB, yB);
    Console.WriteLine($"Расстояние между точками {distanceDot}");
}

// метод для задачи 21 - находит расстояние между двумя точками в 2D пространстве по заданным координатам

double Distance(int x1, int y1, int x2, int y2)
{
    double dis = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
    return dis;
}











// Задача 22 - Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

if (z == 22)
{
    Console.WriteLine("Введите число");
    bool isParsedN = int.TryParse(Console.ReadLine(), out int N);

    if (!isParsedN)
    {
        Console.WriteLine("Ошибка! Это не число");
        return;
    }

    int [] result = TableOfSquares(N);
    PrintArray(result);
}

// метод для задачи 22 - задаёт массив, состоящий из квадратов чисел от 1 до заданного

int [] TableOfSquares(int number)
{
    int[] array = new int[number];

    for (int i = 0; i < number; i++)
    {
        array[i] = (i + 1) * (i + 1);
    }
    return array;
}

// метод для задачи 22 - распечатывает массив

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
