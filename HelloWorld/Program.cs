using System.Reflection.Metadata;

/*
string fn = "Ivan";
string ln = "Lazarev";
string g = "ISP-242";
int by = 2000;
double gpa = 4.5;
bool hasSs = true;

int cury = 2026;
int age = cury - by;

Console.WriteLine("Студенческое удостоверение");
Console.WriteLine($"Имя: {fn} {ln}");
Console.WriteLine($"Группа: {g}");
Console.WriteLine($"Возраст: {age}");
Console.WriteLine($"Средний балл: {gpa}");
Console.WriteLine($"Стипендия: {hasSs}");

Console.Write("\nВведите ваш любимый предмет: ");
Console.WriteLine($"Отлично! {fn} любит {Console.ReadLine()}");
*/

int a = 15; int b = 4;
Console.WriteLine($"Сумма: {a+b}");
Console.WriteLine($"Разность: {a-b}");
Console.WriteLine($"Произведение: {a*b}");
Console.WriteLine($"Частное: {a/b}");
Console.WriteLine($"Остаток: {a%b}");

Console.WriteLine($"Частное {(double)a / b}");

Console.WriteLine(Math.Abs(-5));
Console.WriteLine(Math.Pow(2,10));
Console.WriteLine(Math.Sqrt(144));
Console.WriteLine(Math.Max(10, 25));
Console.WriteLine(Math.Min(10,25));;
Console.WriteLine(Math.Round(3.567, 2));

Console.WriteLine("Калькуляторк");
Console.Write("Введите первое число: ");
double n1 = double.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
double n2 = double.Parse(Console.ReadLine());

Console.WriteLine($"Сумма: {n1 + n2}");
Console.WriteLine($"Разность: {n1 - n2}");
Console.WriteLine($"Произведение: {n1 * n2}");

if (n2 != 0)
{
  Console.WriteLine($"Частное: {n1 / n2}");
}
else
{
  Console.WriteLine("Деление на 0 невозможно!");
}