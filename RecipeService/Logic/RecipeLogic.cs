using RecipeService.DataAccess.Repositories;
using RecipeService.ViewModels;

namespace RecipeService.Logic
{
	public interface IRecipeLogic
	{
		int CreateRecipe(RecipeModel newRecipe);
		RecipeModel GetRecipeById(int recipeId);
	}

	public class RecipeLogic : IRecipeLogic
	{
		private readonly IRecipeRepository _recipeRepository;
		public RecipeLogic(IRecipeRepository recipeRepository)
		{
			_recipeRepository = recipeRepository;
		}

		public int CreateRecipe(RecipeModel newRecipe)
		{
			var recipeId = _recipeRepository.CreateRecipe(newRecipe.Details);
			//ToDo: insert ingredients, instructions, and tags
			return recipeId;
		}

		public RecipeModel GetRecipeById(int recipeId)
		{
			var recipeDetails = _recipeRepository.GetRecipeById(recipeId);
			//ToDo: get the rest of the recipe info (ingredients, instructions, tags, etc)
			return new RecipeModel
			{
				Details = recipeDetails
			};
		}
	}
}
