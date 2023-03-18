using System.IO;

namespace Practice_8._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader r = new StreamReader(path);
            Console.WriteLine(r.ReadLine());
            r.Dispose();
        }
    }
}