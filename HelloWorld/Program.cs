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

/*
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
*/

/*
Console.WriteLine("Добро пожаловать в анк");
Console.Write("Введите ваше имя: ");
string n = Console.ReadLine();
Console.Write("Введите вашу фамилию: ");
string sn = Console.ReadLine();
Console.Write("Введите вашу группу: ");
string g = Console.ReadLine();
Console.Write("Введите ваш год рождения: ");
int by = int.Parse(Console.ReadLine());

Console.Write("Введите ваш средний балл: ");
double avg = double.Parse(Console.ReadLine());
int cy = 2026;
int age = cy - by;
bool isExcellent = avg >= 4.5;

string status;
if (isExcellent) status = "Отличник";
else status = "Хорошист";

Console.WriteLine($"Ваша анкета:");
Console.WriteLine($"Имя: {n} {sn}");
Console.WriteLine($"Группа: {g}");
Console.WriteLine($"Возраст: {age}");
Console.WriteLine($"Средний балл: {avg}");
Console.WriteLine($"Статус: {status}");
Console.WriteLine($"Лет до 30: {30 - age}");

Console.WriteLine("Нажмите Enter для выхода...");
Console.ReadLine();
*/

Console.Write("Ваша любимая игра/кино/аниме: ");
string a2 = Console.ReadLine();
Console.Write("Ваша любимая цифра: ");
string b2 = Console.ReadLine();
Console.Write("Значение числа пи: ");
double c2 = double.Parse(Console.ReadLine());
Console.Write("Ваша любимая буква алфавита: ");
string d2 = Console.ReadLine();

Console.WriteLine($"{a2}");
Console.WriteLine($"{b2}");
Console.WriteLine($"{c2}");
Console.WriteLine($"{d2}");


Console.WriteLine("I");
Console.WriteLine("need");
Console.WriteLine("more");
Console.WriteLine("power!");

Console.WriteLine("\"Hellow There\"");


Console.Write("Стоимость монитора: ");
int a1 = int.Parse(Console.ReadLine());
Console.Write("Стоимость системного блока: ");
int b1 = int.Parse(Console.ReadLine());
Console.Write("Стоимость клавиатура: ");
int c1 = int.Parse(Console.ReadLine());
Console.Write("Стоимость мыши: ");
int d1 = int.Parse(Console.ReadLine());
Console.WriteLine($"{(a1 + b1 + c1 + d1) * 3}");


Console.Write("a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("b: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine($"{3 * Math.Pow(a + b, 3) + 275 * Math.Pow(b, 2) - 127 * a - 41}");


Console.Write("Нпалусы Цельсия: ");
double a3 = double.Parse(Console.ReadLine());
Console.WriteLine($"{1.8 * a3 + 32}");