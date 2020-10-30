using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeService.DataModels
{
	/// <summary>
	/// Maps to lookup.Ingredient
	/// </summary>
	public class Ingredient
	{
		public int IngredientId { get; set; }
		public string Name { get; set; }
	}
}
