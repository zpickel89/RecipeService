using Microsoft.AspNetCore.Mvc;
using RecipeService.Logic;
using RecipeService.ViewModels;

namespace RecipeService.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RecipeController : ControllerBase
	{
		private readonly IRecipeLogic _recipeLogic;
		
		public RecipeController(IRecipeLogic recipeLogic)
		{
			_recipeLogic = recipeLogic;
		}

		/// <summary>
		/// Returns a single recipe with the specified Id
		/// </summary>
		/// <param name="recipeId">The id of the recipe to return</param>
		/// <returns></returns>
		[HttpGet]
		[ProducesResponseType(typeof(RecipeModel), 200)]
		public IActionResult Get(int recipeId)
		{
			return Ok(_recipeLogic.GetRecipeById(recipeId));
		}

		/// <summary>
		/// Creates a new recipe and returns the Id
		/// </summary>
		/// <param name="newRecipe">The new recipe</param>
		/// <returns>The id of the new recipe</returns>
		[HttpPost]
		[ProducesResponseType(typeof(int), 200)]
		public IActionResult Post(RecipeModel newRecipe)
		{
			return Ok(_recipeLogic.CreateRecipe(newRecipe));
		}
	}
}
