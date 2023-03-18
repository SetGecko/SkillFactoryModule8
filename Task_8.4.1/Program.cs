namespace Task_8._4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\Set Gecko\\Desktop\\BinaryFile.bin";

            string fileContent;

            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                // Применяем специализированные методы Read для считывания соответствующего типа данных.
                fileContent = reader.ReadString();
            }

            Console.Write(fileContent);
        }
    }
}