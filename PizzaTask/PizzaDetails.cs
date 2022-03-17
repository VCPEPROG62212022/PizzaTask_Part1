using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTask
{
    class PizzaDetails
    {
        String size = "";
        String pizzabase = "";
        String topping1, topping2, topping3;
        String cheese = "";
        double price = 0;

        public PizzaDetails(string size, string pizzabase, string topping1, string topping2, string topping3, string cheese, double price)
        {
            this.size = size;
            this.pizzabase = pizzabase;
            this.topping1 = topping1;
            this.topping2 = topping2;
            this.topping3 = topping3;
            this.cheese = cheese;
            this.price = price;
        }

        public string Size { get => size; set => size = value; }
        public string Pizzabase { get => pizzabase; set => pizzabase = value; }
        public string Topping1 { get => topping1; set => topping1 = value; }
        public string Topping2 { get => topping2; set => topping2 = value; }
        public string Topping3 { get => topping3; set => topping3 = value; }
        public string Cheese { get => cheese; set => cheese = value; }
        public double Price { get => price; set => price = value; }
    }
}
