using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeService.DataAccess.Repositories;
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

		[HttpGet]
		public IActionResult Get(int recipeId)
		{
			return Ok(_recipeLogic.GetRecipeById(recipeId));
		}

		[HttpPost]
		public IActionResult Post(RecipeModel newRecipe)
		{
			return Ok(_recipeLogic.CreateRecipe(newRecipe));
		}
	}
}
