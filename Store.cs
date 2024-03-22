using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BMG___UML1
{
    internal class Store
    {


        //Method for start:
        public static void Start() {

            //Object creation call + set individual variables.
            Pizza pizza1 = new Pizza("01.", "Margherita", 69, "Tomato & cheese.");
            Pizza pizza2 = new Pizza("02.", "Vesuvio", 75, "Tomato, cheese & ham.");
            Pizza pizza3 = new Pizza("03.", "Cappriciosa", 80, "Tomato, cheese, ham & mushrooms.");
            
            Drink drink1 = new Drink("21.", "Soda", "Cola", 20, "Small-Medium-Large");
            Drink drink2 = new Drink("22.", "Wine", "Red Wine", 40, "Small-Medium-Large");
            Drink drink3 = new Drink("23.", "Beer", "Stout", 30, "Small-Medium-Large");
            
            Customer customer1 = new Customer("Anders Jensen", "Øltorvet 3", "Roskilde", "33445566", "AndersJensen@gmail.com");
            Customer customer2 = new Customer("Jens Andersen", "Maglegårdvej 3", "Roskilde", "11223344", "Jens.Andersen@gmail.com");
            Customer customer3 = new Customer("Christian Frederiksen", "Hansensgade 4", "Roskilde", "55667788", "Christian.Frederiksen@gmail.com");
            
            Order order1 = new Order(pizza1, customer1, drink1);
            Order order2 = new Order(pizza2, customer2, drink2);
            Order order3 = new Order(pizza3, customer3, drink3);

            Console.WriteLine(pizza1.Name + ", " + drink1.TypeDrink + ", " + customer1.Name + ", " + order1.CalculateTotalPrice() + " kr.");
            Console.WriteLine(pizza2.Name + ", " + drink2.TypeDrink + ", " + customer2.Name + ", " + order2.CalculateTotalPrice() + " kr.");
            Console.WriteLine(pizza3.Name + ", " + drink3.TypeDrink + ", " + customer3.Name + ", " + order3.CalculateTotalPrice() + " kr.");
            //order1.Name, order1.customer



        }

         
                
    }
}
