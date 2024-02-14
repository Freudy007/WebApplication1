using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public interface IIngredient
    {
        IEnumerable<IIngredient> GetAll();
        float GetPrix(string Ingerdient);
        string Nom { get; set; }
        float Prix { get; set; }
    }
    public class Ingredient : IIngredient
    {


        public float GetPrix(string Ingerdient)
        {
            return GetAll().Where(x => x.Nom.Equals(Ingerdient)).FirstOrDefault().Prix;
        }

        public IEnumerable<IIngredient> GetAll()
        {
            List<Ingredient> Ingredients = new List<Ingredient>()
            {
                new Ingredient{ Nom="Café", Prix=1},
                new Ingredient{ Nom="Sucre", Prix=0.1f},
                new Ingredient{ Nom="Creme", Prix=0.5f},
                new Ingredient{ Nom="Thé", Prix=2}, 
                new Ingredient{ Nom="Eau", Prix=0.2f},
                new Ingredient{ Nom="Chocolat", Prix=1},
                new Ingredient{ Nom="Lait", Prix=0.4f},
            };
            return Ingredients;
        }


        public string Nom { get; set; }
        public float Prix { get; set; }
    }


}
