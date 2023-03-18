namespace Task_8._4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteBinaryContent();
            ReadBinaryContent();
        }
        // Сделаем метод для записи в файл, его будем запускать первым
        static void WriteBinaryContent()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open("C:\\Users\\Set Gecko\\Desktop\\BinaryFile.bin", FileMode.Open)))
                writer.Write($"Файл изменен {DateTime.Now} на компьютере c ОС {Environment.OSVersion}");
        }

        // Сделаем метод для чтнеия, перенесём в него данные из задания 8.4.1, будем запускать его вторым
        static void ReadBinaryContent()
        {
            string fileContent;

            using (BinaryReader reader = new BinaryReader(File.Open("C:\\Users\\Set Gecko\\Desktop\\BinaryFile.bin", FileMode.Open)))
            {
                // Применяем специализированные методы Read для считывания соответствующего типа данных.
                fileContent = reader.ReadString();
                Console.Write(fileContent);
            }
        }
    }
}