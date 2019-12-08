using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace LAB3_8
{
    class Car
    {
        public string Model { get; set; }
        public Car() { }

        public Car(string model)
        {

            Model = model;
        }
    }

    class Engine : Car
    {
        public Engine()
        {
        }
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }

        public Engine(string model, int enginespeed, int enginepower)
            : base(model)
        {
            EngineSpeed = enginespeed;
            EnginePower = enginepower;
        }
    }

    class Cargo : Engine
    {
        public Cargo() { }
        public int CargoWeight { get; set; }

        public string CargoType { get; set; }

        public Cargo(string model, int enginespeed, int enginepower, int cargoweight, string cargotype)
            : base(model, enginespeed, enginepower)
        {
            CargoWeight = cargoweight;
            CargoType = cargotype;
        }
    }

    class Tires : Cargo
    {
        public Tires() { }
        public double Tire1Pressure { get; set; }
        public int Tire1Age { get; set; }
        public double Tire2Pressure { get; set; }
        public int Tire2Age { get; set; }
        public double Tire3Pressure { get; set; }
        public int Tire3Age { get; set; }
        public double Tire4Pressure { get; set; }
        public int Tire4Age { get; set; }

        public Tires(string model, int enginespeed, int enginepower, int cargoweight,
            string cargotype, double tire1pressure, int tire1age, double tire2pressure,
            int tire2age, double tire3pressure, int tire3age, double tire4pressure, int tire4age)
            : base(model, enginespeed, enginepower, cargoweight, cargotype)
        {
            Tire1Pressure = tire1pressure;
            Tire1Age = tire1age;

            Tire2Pressure = tire2pressure;
            Tire2Age = tire2age;

            Tire3Pressure = tire3pressure;
            Tire3Age = tire3age;

            Tire3Pressure = tire3pressure;
            Tire3Age = tire3age;
        }

        public double findAllPressureValue()
        {
            double pressureValue = (Tire1Pressure + Tire2Pressure + Tire3Pressure + Tire4Pressure) / 4;
            return pressureValue;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во автомобилей");
            int n = int.Parse(Console.ReadLine());

            List<Tires> group = new List<Tires>();

            for (int i = 0; i < n; i++)
            {
                string s1 = Console.ReadLine();
                string[] s2 = s1.Split(" ");
                Tires t = new Tires(s2[0], int.Parse(s2[1]), int.Parse(s2[2]), int.Parse(s2[3]), s2[4], Convert.ToDouble(s2[5]), int.Parse(s2[6]), double.Parse(s2[7]), int.Parse(s2[8]),
                    double.Parse(s2[9]), int.Parse(s2[10]), double.Parse(s2[11]), int.Parse(s2[12]));
                group.Add(t);
            }
            Console.WriteLine("Введите тип груза");
            string type = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                if (type == group[i].CargoType)
                {
                    if (group[i].CargoType == "fragile")
                    {
                        if (group[i].findAllPressureValue() < 1) { Console.WriteLine(group[i].Model); }
                    }
                    if (group[i].CargoType == "flamable")
                    {
                        if (group[i].EnginePower > 250) { Console.WriteLine(group[i].Model); }
                    }
                }
                else
                {
                    Console.WriteLine("Такиз типов груза нету.");
                }
            }
        }
    }
}