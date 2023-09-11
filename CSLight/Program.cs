using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLight
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Основные типы - int | float | char | bool

            // Целочисленные типы
            byte b; // 0 to 255 не используем часто, так как нет смысла экономить на этом память
            sbyte sb; // -128 to 127   -- etc
            short s; // -32768 to 32767   -- etc
            ushort us; // 0 to 65535   -- etc
            int i; // -2147483648 to 2147483647
            uint ui; // 0 to 4294672295
            long l = long.MaxValue; // не всегда нужен, так как очень большой
            ulong ul;
            
            // Числа с плавающей точкой
            float f = 5.7f; // до 7 знаков после запятой (ставится f, так как он меньше чем double)  --используется часто
            double d = 5.7; // до 15 знаков после запятой

            // Символьные типы
            char c = 'c'; // Один символ

            // Строковый тип
            string str = "Hello"; // Набор из char

            // Логический тип
            bool bl = true;



            // Арифметические операторы (C# Interactive)

            float result;
            int x, y;

            x = 5;
            y = 2;

            result = Convert.ToSingle(x) / y;

            Console.WriteLine(result);


            // Деление по модулю
            int timeInMinutes = 130;
            int hour;
            int minute;

            hour = timeInMinutes / 60;
            minute = timeInMinutes % 60;

            Console.WriteLine(hour + " - Количество часов в переменной timeInMinutes");
            Console.WriteLine(minute + " - Количество лишних минут в переменной timeInMinutes");



            // Сокращенная запись
            int age = 18;
            age++;
            age += 1;
            age -= 1;
            age /= 1;
            age *= 1;
            age %= 1;


            //Приоритет действий как в математике




            // Урок 2
            // Логические операторы
            // == != > >= < <=

            age = 18;
            bool accesIsAllowed;
            accesIsAllowed = age >= 18;
            Console.WriteLine(accesIsAllowed);


            // Конкатенация строк

            string greeting = "Hello";
            string name = "Dmitriy";
            age = 1;
            string message = greeting + " " + name;
            Console.WriteLine(message + " " + (age + 5)); //необходимо помнить про приоритет



            //ИНТЕРПОЛЯЦИЯ
            age = 27;
            name = "Dimon";

            Console.WriteLine("Your name: " + name + " age " + age);
            Console.WriteLine($"You name: {name} age {age}"); //ИНТЕРПОЛЯЦИЯ




            //КОНВЕРТАЦИЯ
            int age1;
            string input = "15";
            age1 = Convert.ToInt32(input);
            Console.WriteLine(age1);

            float result1;
            int x1 = 5, y1 = 2;
            result1 = Convert.ToSingle(x1) / y1;
            Console.WriteLine(result1);

            int trigger = 1;
            bool triggerBoolean = Convert.ToBoolean(trigger);
            Console.WriteLine(triggerBoolean);


            //Действия с консолью

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            string name2;
            Console.Write("Enter you name: "); //Отмена переноса строки
            //name2 = Console.ReadLine();
            //Console.WriteLine($"Name: {name2}");

            int yourAge;
            Console.Write("Enter you age: "); //Отмена переноса строки
            //yourAge = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Age: {yourAge}");


            //Инкремент и декремент
            // ++ --
            // ++i сначала увеличивает значение - потом возвращает
            // i++ сначала возвращает значение - потом увеличивает
            // У инкремента и декремента наивысший приотритет
            int integer = 0;
            Console.WriteLine(++integer);

            


            Console.ReadKey(); // Останавливает программу перед выходом (Ctrl + F5)





        }
    }
}
