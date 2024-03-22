using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMG___UML1
{
    internal class Drink
    {
        // instance variables/instance fields:
        private string _id;
        private string _typeDrink;
        private string _name;
        private double _price;
        private string _size;

        //Constructor for Drink
        public Drink(string id, string typeDrink, string name, double price, string size)         //Constructor signature.
        {
            _id = id;
            _typeDrink = typeDrink;
            _name = name;
            _price = price;
            _size = size;
        }

        //Properties - get-return for ID, TypeDrink, Name, Price, Size.
        public string Id { get { return _id; } }   
        public string TypeDrink { get { return _typeDrink; } }
        public string Name { get { return _name; } }    
        public double Price { get { return _price;} }
        public string Size { get { return _size;} }

        public override string ToString()
        {
            return _name;
        }



    }
}
