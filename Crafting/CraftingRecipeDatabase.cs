using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Crafting
{
	// Token: 0x020007A9 RID: 1961
	[Token(Token = "0x20007A9")]
	[CreateAssetMenu(fileName = "CraftingRecipeDatabase", menuName = "Sons/Crafting/RecipeDatabase")]
	public class CraftingRecipeDatabase : ScriptableObject
	{
		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x060033DE RID: 13278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700069A")]
		public IEnumerable<CraftingRecipe> Recipes
		{
			[Token(Token = "0x60033DE")]
			[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200")]
			get
			{
				return null;
			}
		}

		// Token: 0x060033DF RID: 13279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033DF")]
		[Address(RVA = "0x2E58980", Offset = "0x2E57980", VA = "0x182E58980")]
		public List<CraftingRecipe> FindCompleteRecipesWitItems(List<int> allItemIds)
		{
			return null;
		}

		// Token: 0x060033E0 RID: 13280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033E0")]
		[Address(RVA = "0x2E58CC0", Offset = "0x2E57CC0", VA = "0x182E58CC0")]
		public List<CraftingRecipe> FindRecipesWithIngredients(List<CraftingIngredient> ingredients)
		{
			return null;
		}

		// Token: 0x060033E1 RID: 13281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033E1")]
		[Address(RVA = "0x2E59020", Offset = "0x2E58020", VA = "0x182E59020")]
		public CraftingRecipeDatabase()
		{
		}

		// Token: 0x04002CEC RID: 11500
		[Token(Token = "0x4002CEC")]
		private const string CraftingRecipesPath = "Assets/Sons/Crafting/Recipes/";

		// Token: 0x04002CED RID: 11501
		[Token(Token = "0x4002CED")]
		[FieldOffset(Offset = "0x18")]
		public string _newRecipeName;

		// Token: 0x04002CEE RID: 11502
		[Token(Token = "0x4002CEE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<CraftingRecipe> _recipes;
	}
}
