using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
    /// restaurante.
    /// </summary>
    public class Menu
    {
        private List<Dish> Dishes = new List<Dish>();
        
        

        public void AddDish(Dish plato)
        {
            Dishes.Add(plato);
        }

        public void RemoveDish(Dish plato)
        {
            Dishes.Remove(plato);
        }
        
        public Dish GetDishByName(string name)
        {
            for (int i = 0; i < Dishes.Count; i++)
            {
                if (Dishes[i].ToString() == name)
                {
                    return Dishes[i];
                }
            }
            return null; // si no lo encuentra
        }
    }

    }
