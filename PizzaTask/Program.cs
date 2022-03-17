using System;

namespace PizzaTask
{
    class Program
    {
        static void Main(string[] args)
        {

            PizzaDetails Basicpizza =  new PizzaDetails("Large", "Thick", "None", "None", "Cheese", "Yellow", 70);



            PizzaDetails[] GabesPizza = new PizzaDetails[4];
            GabesPizza[0] = new PizzaDetails("Large", "Thick", "None", "None", "Cheese", "Yellow", 70);
            GabesPizza[1] = new PizzaDetails("Large", "Thin", "Bacon", "Pineapple", "Cheese", "Yellow", 85);
            GabesPizza[2] = new PizzaDetails("Large", "Thick", "Mushroom", "Chili Peppers", "Cheese", "Yellow", 90);
            GabesPizza[3] = Basicpizza;


            Order Gabe = new Order(GabesPizza, "Durban Road , South End ","Gabe");


            Order[] PizzaHutOrders = new Order[40];

            PizzaHutOrders[0] = Gabe;
            PizzaHutOrders[1]= new Order(GabesPizza, "Durban Road , South End ", "Gabe");





            Console.WriteLine(  Gabe.ToString());



        }
    }
}
