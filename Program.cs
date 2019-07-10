using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building TheJason = new Building("123 Jason Blvd")
            {
                Width = 300.3,
                Depth = 400.5,
                Stories = 2
            };
            TheJason.Construct();
            TheJason.Purchase("Fred Rogers");
            // TheJason.Details();

            Building TheN8 = new Building("8 North Avenue")
            {
                Width = 500.3,
                Depth = 500.5,
                Stories = 3
            };
            TheN8.Construct();
            TheN8.Purchase("Steph Curry");
            // TheN8.Details();

            Building TheColinies = new Building("1984 Alabama Street")
            {
                Width = 1300.3,
                Depth = 1400.5,
                Stories = 8
            };
            TheColinies.Construct();
            TheColinies.Purchase("Donald J. Trump");
            // TheColinies.Details();

            City Jasonville = new City("Jasonville", "J. W. Sonn", 1932);
            Jasonville.AddBuilding(TheN8);
            Jasonville.AddBuilding(TheJason);

            foreach (Building building in Jasonville.Buildings)
            {
                building.Details();
            }
        }
    }
}
