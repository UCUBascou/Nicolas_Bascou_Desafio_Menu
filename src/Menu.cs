using System.Collections.Generic;
using System.Globalization;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
    /// restaurante.
    /// </summary>
    public class Menu
    {
        //Atributo list of dishes
        private List<Dish> dishes = new List<Dish>();
        public List<Dish> Dishes
        {
            get {return this.dishes;}
        }

        //Add new dish
        public void AddDish(Dish newdish)
        {
            Dishes.Add(newdish);
        }

        //Remove Dish
        public void RemoveDish(Dish dish)
        {
            Dishes.Remove(dish);
        }

        //Buscar Dish y devolver
        public Dish GetDishByName(string dishname)
        {
            List<string> dishnames = new List<string>();
            
            foreach (Dish dish in Dishes)
            {
                dishnames.Add(dish.Name);

                if (dish.Name == dishname)
                {
                    return dish;
                }
            }
            
            //Devuelve null cuando no encuentra el plato deseado.
            return null;
            
        }

        //Constructor
        public Menu()
        {
            ;
        }

    }
}