using RecipeService.DataModels;
using System;
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
			throw new NotImplementedException();
		}

		public Recipe GetRecipeById(int recipeId)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Recipe> GetRecipies()
		{
			throw new NotImplementedException();
		}

		public bool UpdateRecipe(Recipe updatedRecipe)
		{
			throw new NotImplementedException();
		}
	}
}
