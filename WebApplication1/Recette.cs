using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public interface IRecette
    {
        IDictionary<string, IEnumerable<IDose>> Get();
    }




    public interface IDose
    {
        string NomIngredient { get; set; }
        int Qtt { get; set; }
    }
    public class Dose: IDose
    {
        public string NomIngredient { get; set; }
        public int Qtt { get; set; }
    }


    public class Recette : IRecette
    {
        IIngredient _ingredient;


        public Recette(IIngredient ingredient)
        {
            _ingredient = ingredient;
        }



        public IDictionary<string, IEnumerable<IDose>> Get()
        {
            Dictionary<string, IEnumerable<IDose>> Recettes = new Dictionary<string, IEnumerable<IDose>>();

            List<Dose> Doses = new List<Dose>();
            Doses.Add(new Dose { NomIngredient = "Café", Qtt = 1 });
            Doses.Add(new Dose { NomIngredient = "Eau", Qtt = 1 });
            Recettes.Add("Expresso", Doses);

            Doses = new List<Dose>();
            Doses.Add(new Dose { NomIngredient = "Café", Qtt = 1 });
            Doses.Add(new Dose { NomIngredient = "Eau", Qtt = 2 }); 
            Recettes.Add("Allongé", Doses);

            Doses = new List<Dose>();
            Doses.Add(new Dose { NomIngredient = "Café", Qtt = 1 });
            Doses.Add(new Dose { NomIngredient = "Chocolat", Qtt = 1 });
            Doses.Add(new Dose { NomIngredient = "Eau", Qtt = 2 });
            Doses.Add(new Dose { NomIngredient = "Crème", Qtt = 1 });
            Recettes.Add("Capuccino", Doses);

            Doses = new List<Dose>();
            Doses.Add(new Dose { NomIngredient = "Chocolat", Qtt = 3 });
            Doses.Add(new Dose { NomIngredient = "Lait", Qtt = 2 });
            Doses.Add(new Dose { NomIngredient = "Eau", Qtt = 1 });
            Doses.Add(new Dose { NomIngredient = "Sucre", Qtt = 1 });
            Recettes.Add("Chocolat", Doses);

            Doses = new List<Dose>();
            Doses.Add(new Dose { NomIngredient = "Thé", Qtt = 1 });
            Doses.Add(new Dose { NomIngredient = "Eau", Qtt = 2 });
            Recettes.Add("Thé", Doses);


            Doses = new List<Dose>();
            Doses.Add(new Dose { NomIngredient = "Thé", Qtt = 1 });
            Recettes.Add("TEst", Doses);




            return Recettes;
        }
    }
}
