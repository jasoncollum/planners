using System;
using System.Collections.Generic;

namespace Planner
{
    class City
    {
        //  Properties
        public string Name { get; set; }
        public string Mayor { get; set; }
        public int YearEst
        { get; set; }
        public List<Building> Buildings { get; set; }

        // Constructor
        public City(string name, string mayor, int year)
        {
            Name = name;
            Mayor = mayor;
            YearEst = year;
            Buildings = new List<Building>();
        }

        // Methods
        public void AddBuilding(Building building)
        {
            Buildings.Add(building);
        }
    }
}