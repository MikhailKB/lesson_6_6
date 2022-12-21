using System;
using System.IO;
using System.Text;
using static System.Console;

namespace Lesson_6_6
{
    class Program
    {
        static void ReadDataStaff()
        {
            using (StreamReader sr = new StreamReader(@"C:\SkillBox\data.txt"))
            {
                string line;
                string[] pattern = new string[]
            { "ID: ",
              "дата и время: ",
              "Ф.И.О: ",
              "возраст: ",
              "рост: ",
              "дата рождения: ",
              "место рождения: "};
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split('#');
                    Write($"{pattern[0]}{data[0]}"+" ");
                    Write($"{pattern[1]}{data[1]}"+" ");
                    Write($"{pattern[2]}{data[2]}"+" ");
                    Write($"{pattern[3]}{data[3]}"+" ");
                    Write($"{pattern[4]}{data[4]}"+" ");
                    Write($"{pattern[5]}{data[5]}"+" ");
                    Write($"{pattern[6]}{data[6]}");
                    WriteLine();
                }
                ReadKey();
            }
        }
        static void WriteDataStaff()
        {
            using (StreamWriter sw = new StreamWriter(@"C:\SkillBox\data.txt", true, Encoding.Unicode))
            {
                string info = string.Empty;
                WriteLine("Введите ID:");
                info += $"{ReadLine()}"+"#";

                string timenow = DateTime.Now.ToString();
                WriteLine($"Введите Дату и время добавления записи:\n{timenow}");
                info += $"{(timenow)}"+"#";

                WriteLine("Введите Ф.И.О:");
                info += $"{ReadLine()}"+"#";

                WriteLine("Введите возраст:");
                info += $"{ReadLine()}"+"#";

                WriteLine("Введите рост:");
                info += $"{ReadLine()}"+"#";

                WriteLine("Введите дату рождения:");
                info += $"{ReadLine()}"+"#";

                WriteLine("Введите место рождения:");
                info += $"{ReadLine()}";
                sw.WriteLine(info);
                ReadKey();
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Clear();
                Write("Введите 1 или 2.\n1 — вывести данные на экран\n2 — заполнить данные и добавить новую запись \nВвод: ");
                int choice = int.Parse(ReadLine());
                switch (choice)
                {
                    case 1:
                        ReadDataStaff();
                        break;
                    case 2:
                        WriteDataStaff();
                        break;
                }
                ReadKey();
            }
        }
    }
}