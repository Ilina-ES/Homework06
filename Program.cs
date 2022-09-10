Start();

void Start()
{
    while (true)
    {
        Console.ReadLine();
        Console.Clear();

        System.Console.WriteLine("41) Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
        System.Console.WriteLine("43) Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем. (b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5))");
        System.Console.WriteLine("0) End");

        int numTask = SetNumber("task");

        switch (numTask)
        {
            case 0:  break;
            case 41: PosNumbers(); break;
            case 43: Intersection(); break;

            default: System.Console.WriteLine("error"); break;
        }
    }
}

int SetNumber(string numberName)
{
    Console.Write($"Выберите номер задачи {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void PosNumbers()
{
Console.Write("Введите числа через пробел:");
string[] number = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
int count = 0;

for(int i = 0; i < number.Length; i++)
{
    if((int.Parse(number[i])) > 0)
    {
        count = count+1;
    }
}
Console.WriteLine($"[{string.Join(", ", number)}] -> количество чисел больше 0 равно: {count}]");
}

void Intersection()
{
Console.Write("Введите число k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

if((k1 * b2 - k2 * b1) == 0)
{
    Console.WriteLine("Прямые параллельны другу друг и не имеют точек пересечения");
}
else 
{
    double x = (b2-b1)/(k1-k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2 равна ({x},{y})");
}
}