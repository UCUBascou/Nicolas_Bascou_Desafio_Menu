using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa una mesa en el restaurante con  su Numero, Estado de ocupacion y Orden correspondiente
    /// </summary>
    public class Table
    {
        //Atributos
        private int number;
        public int Number
        {
            get { return this.number;} set { this.number = value;}
        }

        private bool isOccupied;
        public bool IsOccupied
        {
            get { return this.isOccupied;} set {this.isOccupied = value;}
        }

        //Order information (object)
        private Order order;
        public Order Order
        {
            get{return this.order;}
        }



        //Anadir plato a la orden
        public void AddToOrder(Dish newdish)
        {
            Order.Orders.Add(newdish);
        }

        //Marcar y Ocupar la mesa
        public void Occupy()
        {
            IsOccupied = true;
        }

        //Vaciar mesa y pedidos
        public void Free()
        {
            IsOccupied = false;
            Order.Orders.Clear();
        }

        //Chequear si la orden tiene pedidos
        public bool HasOrders()
        {
            if (Order.Orders.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

            //Alternativo
            //return Order.Count > 0;
        }

        //Constructor
        public Table(int tnumber, bool esDelivery)
        {
            this.number = tnumber;
            this.order = new Order(tnumber, esDelivery);
        }

    }
}