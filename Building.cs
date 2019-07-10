using System;

namespace Planner
{
    class Building
    {
        // Fields
        private string _designer = "Jason";
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;

        // Properties
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }

        // Constructor
        public Building(string address)
        {
            _address = address;
        }

        // Methods
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string purchaserName) => _owner = purchaserName;

        public void Details()
        {
            Console.WriteLine("");
            Console.WriteLine(_address);
            Console.WriteLine($"---------------");
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume} cubic meters of space");
        }
    }
}