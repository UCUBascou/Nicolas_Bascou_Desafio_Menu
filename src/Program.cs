using System;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Programa principal.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto del entrada al programa.
        /// </summary>
        public static void Main()
        {
            //Crear los platos
            Dish burger = new Dish("Burger", 5.99, false);
            Dish salad = new Dish("Salad", 4.99, true);
            Menu menu = new Menu();

            //anadir los platos al menu
            menu.AddDish(burger);
            menu.AddDish(salad);

            //Crear mesa y moso
            Table oneTable = new Table(1, false);
            Waiter waiter = new Waiter("John");

            //Manejo de mesas
            waiter.AssignTable(oneTable);
            oneTable.Occupy();
            waiter.TakeOrder(oneTable, burger);

            //Escribir en la consola
            Console.WriteLine(
                 $"La mesa {oneTable.Number} está ocupada: {oneTable.IsOccupied} " +
                 $"y la atiende: {waiter.Name}");
            oneTable.Free();
            Console.WriteLine(
                 $"La mesa {oneTable.Number} está ocupada: {oneTable.IsOccupied}");
        }
    }
}