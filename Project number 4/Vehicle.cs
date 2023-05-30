using Project_number_4;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project_number_4
{
    class Vehicle
    {

        private string _make = "";
        private string _model = "";
        private string _year = "";
        private string _nextService = "";
        public Vehicle(string type)//constrctor 
        {
            Console.WriteLine($"make your {type} ,put  value inside");
            Console.WriteLine("put maker");
            _make = Console.ReadLine();
            Console.WriteLine("put model");
            _model = Console.ReadLine();
            Console.WriteLine("put year");
            _year = Console.ReadLine();
            Console.WriteLine("put Next Service date");
            _nextService = Console.ReadLine();
        }
        public override string ToString()
        {
            return $"  make : {_make} model {_model} year {_year} service {_nextService}  ";
        }
    }
    class car : Vehicle
    {
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
        private string _color = "";

        public car(string type) : base(type)
        {
            Console.WriteLine("put color for the car ");
            _color = Console.ReadLine();
        }
        public override string ToString()
        {
            return $" car color  : {_color}   " + base.ToString();
        }
    }
    class boat : Vehicle
    {
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _name = "";
        public boat(string type) : base(type)
        {
            Console.WriteLine("put Name for the boat ");
            _name = Console.ReadLine();
        }
        public override string ToString()
        {
            return $" Boat name  : {_name}   " + base.ToString();
        }
    }
}
class Truck : Vehicle
{
    public int Weight
    {
        get { return _weight; }
        set { _weight = value; }
    }
    private int _weight;
    public Truck(string type) : base(type)
    {
        Console.WriteLine("put weight  for the truck ");
        _weight = int.Parse(Console.ReadLine());
    }
    public override string ToString()
    {
        return $" truck weight  : {_weight}   " + base.ToString();
    }
}

