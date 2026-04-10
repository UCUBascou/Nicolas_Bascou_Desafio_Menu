using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa un mozo en el restaurante, encargado de atender mesas.
    /// </summary>
    public class Waiter
    {
        //Atributos

        private string name;
        public string Name
        {
            get { return this.name;} set { this.name = value;}
        }

        private List<Table> assignedTables = new List<Table>();
        public List<Table> AssignedTables
        {
            get { return this.assignedTables;}
        }


        //Metodos

        //Asignar nueva mesa
        public void AssignTable(Table newtable)
        {
            AssignedTables.Add(newtable);
        }

        //Anadir nueva order a la mesa correspondiente
        public void TakeOrder(Table tableorder, Dish newdish)
        {
            tableorder.AddToOrder(newdish);
        }

        //Constructor
        public Waiter(string wname)
        {
            this.name = wname;
        }
    }
}