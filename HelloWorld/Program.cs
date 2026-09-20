// Console.WriteLine("Привет от ИСП-241!");
// Console.WriteLine("Автор: Дудаков Иван");
// Console.WriteLine("Год 2026");

// using System.Collections.Specialized;

// int age = 20;
// double gpa = 4.5;
// bool isStudent = true;
// string name = "Иван";

// Console.WriteLine(name);
// Console.WriteLine(age);
// Console.WriteLine(gpa);
// Console.WriteLine(isStudent);


// var city = "Москва";
// var year = 2026;
// var pi = 3.14159;
// var isActive = true;


// string myName = "Иван";
// int myAge = 18;
// string myGroup = "ИСП-241";

// Console.WriteLine($"Меня зовут {myName}, мне {myAge} лет, я учусь в группе {myGroup}.");

// Console.Write("Введите ваше имя: ");
// string name2 = Console.ReadLine();
// Console.WriteLine($"Привет, {name2}!");

// Console.Write("Введите ваш возраст: ");
// int age2 = int.Parse(Console.ReadLine());
// Console.WriteLine($"Через 10 лет вам будет {age2 + 10} лет.");



// int x = 10;
// int y = 3;
// Console.WriteLine(x + y);
// System.Console.WriteLine(x - y);
// System.Console.WriteLine(x * y);
// System.Console.WriteLine(x / y);
// System.Console.WriteLine(x % y);


// string firstName = "Иван";
// string lastName = "Дудаков";
// string group = "ИСП-241";
// int birthYear = 2008;
// double gpa = 4.5;
// bool hasScholarship = false;

// int currentYear = 2026;
// int age = currentYear - birthYear;

// System.Console.WriteLine("Студенческое удостоверение");
// System.Console.WriteLine($"Имя: {firstName} {lastName}");
// System.Console.WriteLine($"Группа: {group}");
// System.Console.WriteLine($"Возраст: {age} лет");
// System.Console.WriteLine($"Средний балл: {gpa}");
// System.Console.WriteLine($"Стипендия: {hasScholarship}");

// Console.Write("\nВведите ваш любимый предмет: ");
// string subject = Console.ReadLine();
// System.Console.WriteLine($"Отлично! {firstName} любит {subject}.");



// int a = 15;
// int b = 4;
// System.Console.WriteLine($"Сумма: {a + b}");
// System.Console.WriteLine($"Разность: {a - b}");
// System.Console.WriteLine($"Произведение: {a * b}");
// System.Console.WriteLine($"Частное (int): {a / b}");
// System.Console.WriteLine($"Остаток: {a % b}");
// System.Console.WriteLine($"Частное (double): {(double)a / b}");


// System.Console.WriteLine(Math.Abs(-5));
// System.Console.WriteLine(Math.Pow(2, 10));
// System.Console.WriteLine(Math.Sqrt(144));
// System.Console.WriteLine(Math.Max(10, 25));
// System.Console.WriteLine(Math.Min(10, 25));
// System.Console.WriteLine(Math.Round(3.567, 2));


// System.Console.WriteLine("Калькулятор");
// System.Console.WriteLine("Введите первое число:");
// double num1 = double.Parse(Console.ReadLine());
// System.Console.WriteLine("Введите второе число:");
// double num2 = double.Parse(Console.ReadLine());
// System.Console.WriteLine($"Сумма: {num1 + num2}");
// System.Console.WriteLine($"Разность: {num1 - num2}");
// System.Console.WriteLine($"Произведение: {num1 * num2}");
// if (num2 != 0)
// {
//     System.Console.WriteLine($"Частное: {num1 / num2}");
// }
// else
// {
//     System.Console.WriteLine("Деление на ноль невозможно!");
// }


// System.Console.WriteLine(int.MaxValue);
// System.Console.WriteLine(int.MinValue);
// System.Console.WriteLine(double.MaxValue);
// System.Console.WriteLine(double.MinValue);


System.Console.WriteLine("Добро пожаловать в анкету!");
System.Console.WriteLine("Введите ваше имя:");
string name = Console.ReadLine();
System.Console.WriteLine("Введите вашу фамилию:");
string surname = Console.ReadLine();
System.Console.WriteLine("Введите вашу группу:");
string group = Console.ReadLine();
System.Console.WriteLine("Введите ваш год рождения:");
int birthYear = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите ваш средний балл (например 4,5):");
double gpa = double.Parse(Console.ReadLine());

int currentYear = 2026;
int age = currentYear - birthYear;
bool isExcellent = gpa >= 4.5;

string status = isExcellent ? "Отличник" : "Хорошист";


System.Console.WriteLine("Ваша анкета");
System.Console.WriteLine($"Имя: {name} {surname}");
System.Console.WriteLine($"Группа: {group}");
System.Console.WriteLine($"Возраст {age} лет");
System.Console.WriteLine($"Средний балл: {gpa}");
System.Console.WriteLine($"Статус: {status}");
System.Console.WriteLine($"Лет до 30: {30 - age}");
System.Console.WriteLine("Нажмите Enter для выхода");
Console.ReadLine();