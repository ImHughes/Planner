using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building1 = new Building("152 8Th Avenue")
            {
                Width = 500.50,
                Depth = 30.50,
                Stories = 3,
            };

            building1.setVolume();
            building1.setDesigner("Hughes Speer");
            building1.Construct();
            // building1.Purchase("Bilbo Baggens");

            Building building2 = new Building("123 Chicken Pike")
            {
                Width = 1000.20,
                Depth = 100.30,
                Stories = 8,
            };

            building2.setVolume();
            building2.setDesigner("Ron Burgundy");
            building2.Construct();
            // building2.Purchase("Sam the Wise");

            var nashville = new City("Nashville", 1991)
            {

                Mayor = "Kaney West"

            };
            var kansasCity = new City("Kansas City", 1600)
            {
                Mayor = "Joel"
            };
            nashville.CityPlaner();
            nashville.AddBuilding(building1);

            foreach (var b in nashville.Buildings)
            {
                Console.WriteLine(nashville.Name);
                b.BuildingInfo();
            }
        }
    }
}



