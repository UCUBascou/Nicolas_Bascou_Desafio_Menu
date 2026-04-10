namespace Ucu.Poo.Restaurant
{

    /// <summary>
    /// Representa un platillo individual en el menú del restaurante. Contiene atributos sobre su; Nombre, Precio y si es vegetariano.
    /// </summary>
    public class Dish
    {
        //Atributos
        private string name;
        public string Name
        {
            get { return this.name;} set { this.name=value;}
        }

        private double precio;
        public double Price
        {
            get { return this.precio;} set { this.precio = value;}
        }

        private bool isvegetarian;
        public bool IsVegetarian
        {
            get { return this.isvegetarian;} set { this.isvegetarian = value;}
        }


        //Constructor
        public Dish(string setname, double setprecio, bool setisvegetarian)
        {
            this.Name = setname;
            this.Price = setprecio;
            this.IsVegetarian = setisvegetarian;
        }
    }
}