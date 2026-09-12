using System.Reflection.Metadata;

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

