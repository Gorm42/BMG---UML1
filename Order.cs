using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMG___UML1
{

    //Make the whole order method with all the increments. Each time an order is made
    //add +1 to the OrderId or something.
    internal class Order
    {
        static int orderIdCounter = 0;
        Pizza _pizza;                 //instance field/variable with datatype Pizza (the class Pizza)
        Customer _customer;           //instance field/variable with datatype customer
        Drink _drink;                 //instance field/variable with datatype Drink
        

        //Constructor
        public Order(Pizza pizza, Customer customer, Drink drink) {
            OrderId = orderIdCounter;
            orderIdCounter++;

            _pizza = pizza;
            _customer = customer;
            _drink = drink;                        
        }

        //property get-set for orderIdCounter
        private int OrderId { get; set; }

        //method for calculatetotalprice:
        public double CalculateTotalPrice()
        {
            double totalPrice = ((_pizza.Price + _drink.Price)* 1.25) + 40;
            return totalPrice;
        }
        //method for OrderPizzaName
        public string OrderPizzaName()
        {
            string pizzaName = _pizza.Name;
            return pizzaName;
        }

        //property for Customer, Pizza, Drinks.
        public Customer Customer {get { return _customer; }}

        //ToString Order:
        public override string ToString()
        {
            return _pizza + ", " + _customer + ", " + _drink + " " + orderIdCounter;
        }




    }
    
}
