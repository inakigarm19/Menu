using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    public class Waiter
    {
        public string Name;
        private List<Table> assignedTables = new List<Table>();

        public Waiter(string name)
        {
            Name = name;
        }

        public void AssignTable(Table table)
        {
            assignedTables.Add(table);
        }

        public void TakeOrder(Table table, Dish dish)
        {
            table.AddDish(dish); // Añada el platillo, cambiar a nombre del metodo que tenga Table
        }
    }
}