namespace Practice_8._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Укажем путь 
            string filePath = @"D:\\Skillfactory\\text.txt";

            // Проверим, существует ли файл по данному пути
            if (!File.Exists(filePath))
            {
                //   Если не существует - создаём и записываем в строку
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.WriteLine("Олег");
                    sw.WriteLine("Дмитрий");
                    sw.WriteLine("Иван");
                }
            }

            // Откроем файл и прочитаем его содержимое
            using (StreamReader sr  = File.OpenText(filePath))
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