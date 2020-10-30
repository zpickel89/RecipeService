
namespace RecipeService.DataModels
{
	/// <summary>
	/// Maps to dbo.Recipe
	/// </summary>
	public class Recipe
	{
		public int RecipeId { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public int CreatedByUserId { get; set; }
	}
}
