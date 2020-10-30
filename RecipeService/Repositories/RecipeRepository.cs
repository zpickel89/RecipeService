using RecipeService.DataModels;
using System.Collections.Generic;

namespace RecipeService.DataAccess.Repositories
{
	public interface IRecipeRepository
	{
		IEnumerable<Recipe> GetRecipies();
		Recipe GetRecipeById(int recipeId);
		int CreateRecipe(Recipe newRecipe);
		bool UpdateRecipe(Recipe updatedRecipe);

	}

	public class RecipeRepository : IRecipeRepository
	{
		public int CreateRecipe(Recipe newRecipe)
		{
			return 1;
		}

		public Recipe GetRecipeById(int recipeId)
		{
			return new Recipe();
		}

		public IEnumerable<Recipe> GetRecipies()
		{
			return new List<Recipe>();
		}

		public bool UpdateRecipe(Recipe updatedRecipe)
		{
			return true;
		}
	}
}
