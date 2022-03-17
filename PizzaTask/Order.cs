using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTask
{
    class Order
    {
        private PizzaDetails[] pizzaOrder;
        private int amountOfPizza = 0;
        private String address = "";
        private double totalBill = 0;
        private String time = "";
        private int orderID = 0;
        private bool delivered = false;
        private String custName;

        public Order(PizzaDetails[] pizzaOrder, string address,String CustName)
        {
            this.pizzaOrder = pizzaOrder;
            this.address = address;
            DateTime CurrentTime = DateTime.Now;
            CurrentTime =CurrentTime.AddMinutes(60);
            string time = CurrentTime.ToString("hh:mm:ss tt");
            this.time = time;
            this.orderID = orderID++;
            custName = CustName;
            CreateTotal();
        }

        private void CreateTotal()
        {
            amountOfPizza= pizzaOrder.Length;

            for (int i = 0; i < amountOfPizza; i++)
            {
                totalBill += pizzaOrder[i].Price;
            }
        }

        override
        public String ToString()
        {
            String strOutput = "Order ID" + OrderID +
                "\n Pizza Order:";
            for (int i = 0; i < amountOfPizza; i++)
            {
                String strTemp = "Pizza " + (i + 1) + " Pizza Base: "
                    + pizzaOrder[i].Pizzabase + ", Pizza size: " + pizzaOrder[i].Size
                    + " Toppings: " + pizzaOrder[i].Topping1 + " "
                    + pizzaOrder[i].Topping2 + " "
                    + pizzaOrder[i].Topping3 + " Price :R" + pizzaOrder[i].Price;

                strOutput += "\n" + strTemp;
            }

            strOutput += "Person Name: " + CustName + " Address: " + Address
                + "Total Bill :R" + TotalBill+" \n Time :"+Time;

            return strOutput;
        }
        public int AmountOfPizza { get => amountOfPizza; }
        public string Address { get => address;}
        public double TotalBill { get => totalBill; }
        public string Time { get => time; }
        public int OrderID { get => orderID; }
        internal PizzaDetails[] PizzaOrder { get => pizzaOrder; set => pizzaOrder = value; }
        public bool Delivered { get => delivered; set => delivered = value; }
        public string CustName { get => custName; set => custName = value; }
    }
}
