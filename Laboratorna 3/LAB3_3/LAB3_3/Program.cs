using System;

namespace LAB3_3
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
    class Family
    {
        Person[] member;

        public Family() { }

        public Family(int size)
        {
            member = new Person[size];
        }

        public void addMember(int i, string[] names, int[] ages)
        {
            member[i] = new Person(ages[i], names[i]);
        }
        public void printInfo()
        {
            for (int i = 0; i < member.Length; i++)
            {
                Console.WriteLine($"{member[i].Name}  {member[i].Age}");
            }
        }
        public Person getOldestMember(int n)
        {

            int oldest = member[0].Age, k = 0;
            for (int i = 0; i < n; i++)
            {
                if (member[i].Age > oldest) { oldest = member[i].Age; k = i; }
            }
            Console.WriteLine($"Самый страшый(ая) в семье - {member[k].Name}, ему(й) {member[k].Age} лет");
            return member[k];

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество членов семьи.");
            int n;
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Ведите имя и возраст членов семьи.");
            int[] ages = new int[n];
            string[] names = new string[n];

            Family fam1 = new Family(n);

            for (int i = 0; i < n; i++)
            {
                names[i] = Console.ReadLine();
                ages[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                fam1.addMember(i, names, ages);
            }

            fam1.printInfo();

            fam1.getOldestMember(n);
        }
    }
}
