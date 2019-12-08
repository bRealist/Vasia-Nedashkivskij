using System;

namespace LAB_3_1
{
    class Person
    {
        private string name;
        private int age;

        public Person() { }

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

            Person p1 = new Person(age, name); //Инициализация с помощью конструктора
            Person p2 = new Person();
            p2.Age = 18;              //Инициализация без помощи конструктора, или "вручную"
            p2.Name = "Anton";        //
            Person p3 = new Person(19, "Oleksiy"); //строка 16
            p1.printInfo(); //Вывод информации о персонах
            p2.printInfo(); //
            p3.printInfo(); //
        }
    }
}
