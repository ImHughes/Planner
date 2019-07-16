using System;
using System.Collections.Generic;

namespace Planner
{

    public class City
    {
        public string Name { get; private set; }

        public string Mayor { get; set; }

        public int YearEstablished { get; private set; }

        public List<Building> Buildings { get; set; } = new List<Building>();

        public void AddBuilding(Building name)
        {
            Buildings.Add(name);
        }
        public City(string name, int yearEstablished)
        {
            Name = name;
            YearEstablished = yearEstablished;
        }

        public void CityPlaner()
        {
            System.Console.WriteLine($"{Name}");
            System.Console.WriteLine($"{Mayor}");
            System.Console.WriteLine($"{YearEstablished}");

        }
    }
}
