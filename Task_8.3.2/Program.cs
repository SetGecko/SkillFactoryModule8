using System.IO;
using System.Reflection;

namespace Task_8._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C:\Users\Set Gecko\source\repos\SkillFactoryModule8
            // Путь где лежит файл программы
            var filePath = new FileInfo("C:\\Users\\Set Gecko\\source\\repos\\SkillFactoryModule8\\Task_8.3.2\\Program.cs");

            using (StreamWriter sw = filePath.AppendText())
            {
                sw.WriteLine($"// Время запуска: {DateTime.Now}");
            }

            //Конструкция для чтения текста из файла но уже с FileInfo
            using (StreamReader sr = filePath.OpenText())
            {
                string str = "";
                while ((str = sr.ReadLine()) != null)
                    Console.WriteLine(str);
            }
        }
    }
}
// Время запуска: 17.03.2023 14:33:43
// Время запуска: 17.03.2023 14:35:13
