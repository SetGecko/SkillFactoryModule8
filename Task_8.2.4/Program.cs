namespace Task_8._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MoveToTrash();
        }
        static void MoveToTrash()
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(@"C:\\Users\Set Gecko\Desktop\testFolder");
                string trashPath = "C:\\$Recycle.Bin\\testFolder";

                dirInfo.MoveTo(trashPath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}