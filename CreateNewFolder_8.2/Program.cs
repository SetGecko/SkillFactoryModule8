namespace CreateNewFolder_8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(@"D:\\777");
            // Объявляем переменную от DirectoryInfo при создании пути в D:\\777
            // Если путь D:\\777 не существует, то создать
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            // Под D:\\777 создать папку SuperFolderrrrr
            dirInfo.CreateSubdirectory("SuperFolderrrrr");
        }
    }
}