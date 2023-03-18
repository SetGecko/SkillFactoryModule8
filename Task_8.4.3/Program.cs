using System.Runtime.Serialization.Formatters.Binary;

namespace Task_8._4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contact = new Contact("Порося", 79991234567, "pososator@rambler.ru");

            // сериализация
            BinaryFormatter formatter = new BinaryFormatter();
            using (var fs = new FileStream("Contact.bin", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, contact);
            }
        }
    }
    [Serializable]
    class Contact
    {
        public string Name { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }

        public Contact(string name, long phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}