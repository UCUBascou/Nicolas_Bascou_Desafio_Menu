using System.Collections.Generic;
using System;
using System.Globalization;

namespace Ucu.Poo.Restaurant
{
    //<Summary>
    //Representa solamente la orden del consumidor, encargador solamente trabajar con la informacion sobre la orden
    //</summary>
    public class Order
    {
        
        //Atributos
        private bool isDelivery;
        public bool IsDelivery
        {
            get { return this.isDelivery;} set { this.isDelivery = value;}
        }

        private int orderNum;
        public int OrderNum
        {
            get { return this.orderNum;} set { this.orderNum = value;}
        }

        private List<Dish> orders = new List<Dish>();
        public List<Dish> Orders
        {
            get {return this.orders;}
        }


        //Metodos

        //Devolver el precio actual de la orden
        public double GetTotal()
        {
            double total = 0;
            foreach (Dish dish in orders)
            {
                total += dish.Price;
            }
            return total;
        }


        //Constructor
        public Order(int orNum, bool esDelivery)
        {
            this.orderNum = orNum;
            this.isDelivery = esDelivery;
        }

    }



















}