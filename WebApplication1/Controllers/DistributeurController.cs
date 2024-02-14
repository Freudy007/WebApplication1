using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DistributeurController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IIngredient _IngredientDb;
        private readonly IRecette _recettDB;

        public DistributeurController(ILogger<WeatherForecastController> logger, IIngredient ingredientDB, IRecette recettDB)
        {
            _logger = logger;
            _IngredientDb = ingredientDB;
            _recettDB = recettDB;
        }

        [HttpGet]
        public float Get(string nomRecette)
        {
            float PrixRecette = 0;
            var recette = _recettDB.Get().Where(x => x.Key.Equals(nomRecette));
            if (recette != null)
            {
                var TheRecette = recette.First();

                foreach (var Ingre in TheRecette.Value)
                {
                    var PrixUnitaire = _IngredientDb.GetPrix(Ingre.NomIngredient) * 1.30f;
                    PrixRecette += PrixUnitaire;
                }
            }
            return PrixRecette;
        }
    }
}
