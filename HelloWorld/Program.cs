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


string firstName = "Иван";
string lastName = "Дудаков";
string group = "ИСП-241";
int birthYear = 2008;
double gpa = 4.5;
bool hasScholarship = false;

int currentYear = 2026;
int age = currentYear - birthYear;

System.Console.WriteLine("Студенческое удостоверение");
System.Console.WriteLine($"Имя: {firstName} {lastName}");
System.Console.WriteLine($"Группа: {group}");
System.Console.WriteLine($"Возраст: {age} лет");
System.Console.WriteLine($"Средний балл: {gpa}");
System.Console.WriteLine($"Стипендия: {hasScholarship}");

Console.Write("\nВведите ваш любимый предмет: ");
string subject = Console.ReadLine();
System.Console.WriteLine($"Отлично! {firstName} любит {subject}.");
