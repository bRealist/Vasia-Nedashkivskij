using System;

namespace LAB3_4
{
    class Person
    {
        private string name;
        private int age;

        public string Name { get; set; }
        public int Age { get; set; }


        public Person()
        {
            Name = "Noname";
            Age = 1;
        }
        public Person(int Age)
        {
            Name = "Noname";
            this.Age = Age;
        }
        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public void printInfo()
        {
            Console.WriteLine($"{Name} {Age}");
        }


    }
    class Team
    {
        Person[] man;

        public Team() { }

        public Team(int size)
        {
            man = new Person[size];
        }

        public void addMan(int i, string[] name, int[] age) { man[i] = new Person(name[i], age[i]); }

        public void printMan(int i) { Console.WriteLine($"{man[i].Name}  {man[i].Age}"); ; }

        public void findMoreThan30(int n, Team test)
        {
            int c = 0;

            for (int i = 0; i < n; i++)
            {
                if (test.man[i].Age > 30) { c++; }
            }

            Person[] sort = new Person[c];

            int r = 0;
            for (int i = 0; i < n; i++)
            {
                if (test.man[i].Age > 30) { sort[r] = new Person(); r++; }
            }

            r = 0;
            for (int i = 0; i < n; i++)
            {
                if (test.man[i].Age > 30) { sort[r].Name = test.man[i].Name; sort[r].Age = test.man[i].Age; r++; }
            }

            int p = sort[0].Name.Length;
            for (int m = 0; m < n * (n - 1); m++)
            {
                for (int i = 0; i < c; i++)
                {

                    for (int q = i + 1; q < c; q++)
                    {

                        if (sort[i].Name.Length > sort[q].Name.Length) { p = sort[q].Name.Length; }
                        else { p = sort[i].Name.Length; ; }
                        for (int j = 0; j < p; j++)
                        {


                            if (sort[i].Name[j] > sort[q].Name[j])
                            {
                                Person t = new Person(sort[i].Name, sort[i].Age);
                                sort[i].Name = sort[q].Name;
                                sort[i].Age = sort[q].Age;
                                sort[q].Name = t.Name;
                                sort[q].Age = t.Age;
                                if (j == 0) { i++; }
                            }

                            if (sort[i].Name[j] < sort[q].Name[j])
                            {
                                Person t = new Person(sort[q].Name, sort[q].Age);
                                sort[q].Name = sort[i].Name;
                                sort[q].Age = sort[i].Age;
                                sort[i].Name = t.Name;
                                sort[i].Age = t.Age;
                                if (j != 0) { i++; }
                            }



                        }

                    }
                }
            }


            for (int i = 0; i < c; i++)
            {
                Console.WriteLine($"{sort[i].Name} {sort[i].Age}");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Введите количество людей.");
                int n = int.Parse(Console.ReadLine());

                Team group = new Team(n);

                Console.WriteLine("Введите имя и возраст людей.");

                string[] names = new string[n];
                int[] ages = new int[n];

                for (int i = 0; i < n; i++) { names[i] = Console.ReadLine(); ages[i] = int.Parse(Console.ReadLine()); }

                for (int i = 0; i < n; i++) { group.addMan(i, names, ages); }


                Console.WriteLine("-----------------------------------------");

                for (int i = 0; i < n; i++) { group.printMan(i); }

                Console.WriteLine("-----------------------------------------");

                group.findMoreThan30(n, group);

                Console.WriteLine("-----------------------------------------");
            }
        }
    }
}
