using System;
using System.Runtime.CompilerServices;
using System.Xml;

string name;
string lastName;
int yearOfBirth;
int year = DateTime.Now.Year;

Console.Write("Работу выполнили Береснев Роман и Кузнецов Александр \n");
Console.Write("Введите свое имя: ");

name = Console.ReadLine();
Console.Write("Введите свою фамилию: ");

lastName = Console.ReadLine();
Console.Write("Введите свой год рождения: ");

yearOfBirth = int.Parse(Console.ReadLine());
int age = year - yearOfBirth;

Console.Write($"Добавлен пользователь с именем: {name} {lastName}\n В возрасте: {age}");
Console.ReadLine();


// Работа 3
string[] toDos = new string[2];
bool running = true; //нужно для того чтобы exit останавливал работу, еще можно было сделать метод и через return

while (running){
    string userInput = Console.ReadLine();

    // есть 2 стула, if else и switch, выполняют одно и то же, но switch выглядит похайповее (удобнее)
    switch (userInput){
        case "exit":
            Console.WriteLine("Завершение работы программы");
            running = false;
            break;

        case "help":
            Console.WriteLine("help — выводит это сообщение.");
            Console.WriteLine("profile — выводит данные пользователя в формате: <Имя> <Фамилия>, <Год рождения> .");
            Console.WriteLine("add — добавляет новую задачу. Формат ввода: add  \"текст задачи\".");
            Console.WriteLine("view — выводит все задачи из массива.");
            Console.WriteLine("exit — завершает цикл и останавливает выполнение программы.");
            break;

        case "profile":
            Console.WriteLine($"{name} {lastName}, {age}");
            break;

        case string s when s.StartsWith("add \""):
            string task = s.Substring(5).TrimEnd('"');

            break;
        case "view":

            break;

        default:
            Console.WriteLine("Неизвестная команда, введите help для вывода списка команд");
            break;
    }
}