using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Crafting
{
	// Token: 0x020006B4 RID: 1716
	[Token(Token = "0x20006B4")]
	[CreateAssetMenu(fileName = "CraftingRecipeDatabase", menuName = "Sons/Crafting/RecipeDatabase")]
	public class CraftingRecipeDatabase : ScriptableObject
	{
		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06002D56 RID: 11606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000607")]
		public IEnumerable<CraftingRecipe> Recipes
		{
			[Token(Token = "0x6002D56")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002D57 RID: 11607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D57")]
		[Address(RVA = "0x3433AE0", Offset = "0x34320E0", VA = "0x183433AE0")]
		public List<CraftingRecipe> FindCompleteRecipesWitItems(List<int> allItemIds)
		{
			return null;
		}

		// Token: 0x06002D58 RID: 11608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D58")]
		[Address(RVA = "0x3433EB0", Offset = "0x34324B0", VA = "0x183433EB0")]
		public List<CraftingRecipe> FindRecipesWithIngredients(List<CraftingIngredient> ingredients)
		{
			return null;
		}

		// Token: 0x06002D59 RID: 11609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D59")]
		[Address(RVA = "0x34342A0", Offset = "0x34328A0", VA = "0x1834342A0")]
		public CraftingRecipeDatabase()
		{
		}

		// Token: 0x040027BF RID: 10175
		[Token(Token = "0x40027BF")]
		private const string CraftingRecipesPath = "Assets/Sons/Crafting/Recipes/";

		// Token: 0x040027C0 RID: 10176
		[Token(Token = "0x40027C0")]
		[FieldOffset(Offset = "0x18")]
		public string _newRecipeName;

		// Token: 0x040027C1 RID: 10177
		[Token(Token = "0x40027C1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<CraftingRecipe> _recipes;
	}
}
