namespace Task_8._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C:\Users\Set Gecko\source\repos\SkillFactoryModule8
            // Путь где лежит файл программы
            string filePath = @"C:\\Users\\Set Gecko\\source\\repos\\SkillFactoryModule8\\\Task_8.3.1\\Program.cs";

            //Конструкция для чтения текста из файла
            using (StreamReader sr = File.OpenText(filePath))
            {
                string str = "";
                // Пока не кончатся строки - считываем из файла по одной и выводим в консоль
                while ((str = sr.ReadLine()) != null)
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}