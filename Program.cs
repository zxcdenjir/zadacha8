double Function(double x)
{
    return 2 * Math.Pow(x, 2) + 3 * x;
}

double a;
double b;
int n;

Console.WriteLine("Функция f(x) = 2x^2 + 3x\n");

bool isValidNumber = false;
while (true)
{
    Console.Write("Введите нижний предел интегрирования (a): ");
    isValidNumber = double.TryParse(Console.ReadLine(), out a);
    if (isValidNumber == false)
        Console.WriteLine("Некорректное значение\n");
    else
    {
        isValidNumber = false;
        break;
    }
}

while (true)
{
    Console.Write("Введите верхний предел интегрирования (b): ");
    isValidNumber = double.TryParse(Console.ReadLine(), out b);
    if (isValidNumber == false)
        Console.WriteLine("Некорректное значение\n");
    else
    {
        isValidNumber = false;
        break;
    }
}

while (true)
{
    Console.Write("Введите количество разбиений (n): ");
    isValidNumber = int.TryParse(Console.ReadLine(), out n);
    if (isValidNumber == false)
        Console.WriteLine("Некорректное значение\n");
    else
    {
        isValidNumber = false;
        break;
    }
}

double h = (b - a) / n;
double sum = 0;
for (int i = 1; i <= n; i++)
{
    double xi = a + i * h - h / 2;
    sum += Function(xi);
}
double integral = h * sum;

Console.WriteLine($"\nИнтеграл равен: {integral}");

StreamWriter writer = new StreamWriter("result.txt");

writer.WriteLine($"Нижний предел интегрирования (a) = {a}");
writer.WriteLine($"Верхний предел интегрирования (b) = {b}");
writer.WriteLine($"Количество разбиений (n) = {n}");
writer.WriteLine($"\nРезультат вычисления интеграла: {integral}");

writer.Close();
