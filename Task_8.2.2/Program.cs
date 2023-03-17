namespace Task_8._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateFiles();
        }
        static void CalculateFiles()
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(@"D:\\");
                if (dirInfo.Exists)
                {
                    Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);
                }

                DirectoryInfo newDirectory = new DirectoryInfo(@"D:\\newDirectory");
                if (!newDirectory.Exists)
                    newDirectory.Create();

                // Получение информации о каталоге
                Console.WriteLine(newDirectory.GetDirectories().Length + dirInfo.GetFiles().Length);
                Console.WriteLine($"Название каталога: {newDirectory.Name}");
                Console.WriteLine($"Полное название каталога: {newDirectory.FullName}");
                Console.WriteLine($"Время создания каталога: {newDirectory.CreationTime}");
                Console.WriteLine($"Корневой каталог: {newDirectory.Root}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}