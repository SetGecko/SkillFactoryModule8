﻿using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization_8._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // объект для сериализации
            var person = new Pet("Rex", 2);
            Console.WriteLine("Объект создан");

            BinaryFormatter formatter = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (var fs = new FileStream("myPets.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, person);
                Console.WriteLine("Объект сериализован");
            }
            // десериализация
            using (var fs = new FileStream("myPets.dat", FileMode.OpenOrCreate))
            {
                var newPet = (Pet)formatter.Deserialize(fs);
                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"Имя: {newPet.Name} --- Возраст: {newPet.Age}");
            }
            Console.ReadLine();
        }
    }
    [Serializable]
    class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Pet(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}