# Лабораторная работа №1. Платформа .NET
ФИО: Дудаков Иван Владимирович\
Группа: ИСП-241\
Дата: 20.09.2026

Было изучено:
1. Базовые команды терминала 
2. Настройка VS Code
3. Создание консольного приложения на C# через dotnet new console
4. Типы данных, переменные, ввод и вывод в консоль
5. Создание репозитория на GitHub и основные команды работы с git

Структура проекта:\
>Lab01_DotNet/ 
>>   ├── HelloWorld/ #Папка проекта
>>>       ├──bin #Готовые результаты сборки проекта
>>>       ├──obj #Папка с временными файлами сборки
>>>       ├──.gitignore #Исключает временные/бинарные файлы
>>>       ├──HelloWorld.csproj #Файл проекта
>>>       ├──Program.cs  #Точка входа приложения
>>   ├── img/ #Папка скриншотов


Пример кода:
```csharp
// Анкета студента
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
```

Главные выводы:\
1. В отличиие от Python в С# переменнные строго типизируются. Если в переменной типом int попробовать присвоить значение с типом string это приведет к ошибке
2. Код на C# сначала преобразуется в промежуточный язык (IL-код), потом CRL переводит его в машинный код. Этот процесс называется JIT-компиляией
3. Большинство инструметов разработки управляются из терминала


|Характеристика|C#/.NET|
|-----|----------------|
|Платформа|.NET (CLR)|
|Компиляция|C# → IL-код → машинный код|
|Запуск|dotnet run|
|Тип переменной|Указывается явно: int x = 5;|
|Вывод в консоль| Console.WriteLine("текст")|
|Ввод от пользователя |Console.ReadLine()|
|Интерполяция строк |$"Привет, {name}!"|
|Целочисленное деление |10 / 3 = 3|
|Дробное деление |(double)10 / 3 = 3.333...|
|Математические функции |Math.Abs(), Math.Pow(), и др.|


Ответы на вопросы:
1. Console.Write() выводит текст в одну строку, а Console.WriteLine() выводит текст в новую с каждым вызовом
2. Произойдет ошибка компиляции
3. Так как при деление 10 на 3 числа имеют тип int, чтобы получить дробный результат надо одному из чисел придать дробный тип
4. var автоматичски определяет тип переменной, но в отличии от динамической типизации в Python переменной нельзя присвоить другой тип после присваивания этой переменной значения
5. Microsoft, Epic Games, Альфа-Банк

