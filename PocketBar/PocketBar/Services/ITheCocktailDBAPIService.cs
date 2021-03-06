﻿using PocketBar.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PocketBar.Services
{
    public interface ITheCocktailDBAPIService
    {
         [Get("/filter.php?g={glass}")]
         Task<CocktailList> GetCocktailsByGlassAsync(string glass);

         [Get("/filter.php?c={category}")]
         Task<CocktailList> GetCocktailsByCategoryAsync(string category);

         [Get("/filter.php?a={alcoholic}")]
         Task<CocktailList> GetCocktailsByAlcoholicAsync(string alcoholic);

         [Get("/filter.php?i={ingredient}")]
         Task<CocktailList> GetCocktailsByIngredientAsync(string ingredient);

         [Get("/lookup.php?iid={ingredientId}")]
         Task<IngredientList> GetIngredientByIdAsync(int ingredientId);

         [Get("/lookup.php?i={drinkId}")]
         Task<CocktailList> GetCocktailByIdAsync(int drinkId);

        [Get("/random.php")]
        Task<CocktailList> GetRandomCocktailAsync();

        [Get("/list.php?g=list")]
        Task<GlassList> GetAllGlassesAsync();

        [Get("/list.php?i=list")]
        Task<IngredientList> GetAllIngredientsAsync();

        [Get("/list.php?c=list")]
        Task<CategoryList> GetAllCategoriesAsync();

        [Get("/search.php?s={searchTerm}")]
        Task<CocktailList> SearchCocktailByTermAsync(string searchTerm);
        [Get("/search.php?i={searchIngredient}")]
        Task<IngredientList> SearchIngredientByNameAsync(string searchIngredient);

    }
}
