using RecipeService.DataModels;
using System.Collections.Generic;

namespace RecipeService.ViewModels
{
	public class RecipeModel
	{
		public Recipe Details { get; set; }

		public IEnumerable<Ingredient> Ingredients { get; set; }

		public IEnumerable<CookingInstruction> Instructions { get; set; }

		public IEnumerable<Tag> Tags { get; set; }
	}
}
