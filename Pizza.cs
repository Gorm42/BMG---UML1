using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMG___UML1
{
    internal class Pizza
    {
        private string _id;   //instance field/instance variabel.
        private string _name; 
        private double _price;
        private string _topping;


        //constructor.
        public Pizza(string id, string name, double price, string topping) //method signature.
            {
                _id = id;
                _name = name;
                _price = price;
                _topping = topping;
            }
        //property - i.e. get-return. Hhv. Id, Name, Price & Topping
        public string Id { get { return _id; } }
        public string Name { get { return _name; } }
        public double Price { get { return _price; } }
        public string Topping { get { return _topping; } }

        //ToString:
        public override string ToString()
        {
            return _name + " " + _topping;
        }

    }
}
