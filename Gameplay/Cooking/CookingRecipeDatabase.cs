using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Gameplay.Cooking
{
	// Token: 0x0200071D RID: 1821
	[Token(Token = "0x200071D")]
	[CreateAssetMenu(fileName = "CookingRecipeDatabase", menuName = "Sons/Cooking/CookingRecipeDatabase")]
	public class CookingRecipeDatabase : ScriptableObject
	{
		// Token: 0x06002F6A RID: 12138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F6A")]
		[Address(RVA = "0x2E256E0", Offset = "0x2E246E0", VA = "0x182E256E0")]
		public IEnumerable<CookingRecipe> FindRecipesWithIngredients(IEnumerable<CookingRecipe.CookingIngredient> ingredients, bool hasCookingPot, bool hasWater)
		{
			return null;
		}

		// Token: 0x06002F6B RID: 12139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F6B")]
		[Address(RVA = "0x2E25490", Offset = "0x2E24490", VA = "0x182E25490")]
		public List<CookingRecipe> FindRecipesWithIngredient(ItemInstance itemInstance, bool hasCookingPot)
		{
			return null;
		}

		// Token: 0x06002F6C RID: 12140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F6C")]
		[Address(RVA = "0x2E252E0", Offset = "0x2E242E0", VA = "0x182E252E0")]
		public List<CookingRecipe> FindRecipesWithIngredient(int itemId, bool hasCookingPot)
		{
			return null;
		}

		// Token: 0x06002F6D RID: 12141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F6D")]
		[Address(RVA = "0x2E25AB0", Offset = "0x2E24AB0", VA = "0x182E25AB0")]
		public CookingRecipeDatabase()
		{
		}

		// Token: 0x040029EB RID: 10731
		[Token(Token = "0x40029EB")]
		private const string CookingRecipesPath = "Assets/Sons/Cooking/Recipes/";

		// Token: 0x040029EC RID: 10732
		[Token(Token = "0x40029EC")]
		[FieldOffset(Offset = "0x18")]
		public string _newRecipeName;

		// Token: 0x040029ED RID: 10733
		[Token(Token = "0x40029ED")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<CookingRecipe> _recipes;
	}
}
