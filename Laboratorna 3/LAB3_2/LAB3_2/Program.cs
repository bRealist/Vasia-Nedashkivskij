using System;

namespace LAB3_2
{
    class Person
    {
        private string name;
        private int age;


        public Person()
        {
            Name = "NoName";
            Age = 1;
        }

        public Person(int Age)
        {
            Name = "NoName";
            this.Age = Age;
        }

        public Person(int Age, string Name)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public void printInfo()
        {
            Console.WriteLine($"{Name} is {Age} years old.");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            Console.WriteLine("Введите ваше имя.");
            name = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст.");
            age = int.Parse(Console.ReadLine());

            Person p1 = new Person(age, name); //Сработает 3 конструктор
            Person p2 = new Person(); //Сработает 1 конструктор
            Person p3 = new Person(19); //Сработает 2 конструктор
            p1.printInfo(); //Вывод информации о персонах
            p2.printInfo(); //
            p3.printInfo(); //
        }
    }
}
