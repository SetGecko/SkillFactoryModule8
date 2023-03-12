namespace Task_8._2._1
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
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}