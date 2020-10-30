using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeService.DataModels
{
	/// <summary>
	/// Maps to CookingInstruction
	/// </summary>
	public class CookingInstruction
	{
		public int CookingInstructionId { get; set; }
		public int RecipeId { get; set; }
		public string Instruction { get; set; }
		public int CreatedByUserId { get; set; }
	}
}
