namespace Task_8._1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Drive hdd = new Drive("hdd", 90000, 65000);
            Console.WriteLine("Свободное место на хдд = {0}",hdd.FreeSpace);            
        }
    }
    public class Drive
    {
        public Drive(string name, long totalSpace, long freeSpace)
        {
            Name = name;
            TotalSpace = totalSpace;
            FreeSpace = freeSpace;

        }

        public string Name { get; }
        public long TotalSpace { get; }
        public long FreeSpace { get; }
    }
}