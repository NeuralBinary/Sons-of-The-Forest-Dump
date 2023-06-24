using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Inventory;
using Sons.Items.Core;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Gameplay.Cooking
{
	// Token: 0x02000874 RID: 2164
	[Token(Token = "0x2000874")]
	[CreateAssetMenu(fileName = "CookingRecipeDatabase", menuName = "Sons/Cooking/CookingRecipeDatabase")]
	public class CookingRecipeDatabase : ScriptableObject
	{
		// Token: 0x06003DC1 RID: 15809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DC1")]
		[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
		public StatRecipe GetDirtyWaterRecipe()
		{
			return null;
		}

		// Token: 0x06003DC2 RID: 15810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DC2")]
		[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
		public StatRecipe GetCleanWaterRecipe()
		{
			return null;
		}

		// Token: 0x06003DC3 RID: 15811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DC3")]
		[Address(RVA = "0x35C51F0", Offset = "0x35C37F0", VA = "0x1835C51F0")]
		public CookingRecipe FindRecipeById(int id)
		{
			return null;
		}

		// Token: 0x06003DC4 RID: 15812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DC4")]
		[Address(RVA = "0x35C52B0", Offset = "0x35C38B0", VA = "0x1835C52B0")]
		public IEnumerable<CookingRecipe> FindAllValidPotRecipes(bool hasWater)
		{
			return null;
		}

		// Token: 0x06003DC5 RID: 15813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DC5")]
		[Address(RVA = "0x35C5470", Offset = "0x35C3A70", VA = "0x1835C5470")]
		public IEnumerable<CookingRecipe> FindRecipesWithAnyIngredients(IEnumerable<CookingRecipe.CookingIngredient> ingredients, bool hasCookingPot, bool hasWater)
		{
			return null;
		}

		// Token: 0x06003DC6 RID: 15814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DC6")]
		[Address(RVA = "0x35C58E0", Offset = "0x35C3EE0", VA = "0x1835C58E0")]
		public CookingRecipe FindCompleteRecipeWithMostIngredients(List<CookingRecipe.CookingIngredient> ingredients, bool hasCookingPot, bool hasWater)
		{
			return null;
		}

		// Token: 0x06003DC7 RID: 15815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DC7")]
		[Address(RVA = "0x35C5E70", Offset = "0x35C4470", VA = "0x1835C5E70")]
		public List<CookingRecipe> FindRecipesWithIngredient(ItemInstance itemInstance, bool hasCookingPot)
		{
			return null;
		}

		// Token: 0x06003DC8 RID: 15816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DC8")]
		[Address(RVA = "0x35C60F0", Offset = "0x35C46F0", VA = "0x1835C60F0")]
		public List<CookingRecipe> FindRecipesWithIngredient(int itemId, bool hasCookingPot)
		{
			return null;
		}

		// Token: 0x06003DC9 RID: 15817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DC9")]
		[Address(RVA = "0x35C62E0", Offset = "0x35C48E0", VA = "0x1835C62E0")]
		public CookingRecipeDatabase()
		{
		}

		// Token: 0x04003413 RID: 13331
		[Token(Token = "0x4003413")]
		private const string CookingRecipesPath = "Assets/Sons/Cooking/Recipes/";

		// Token: 0x04003414 RID: 13332
		[Token(Token = "0x4003414")]
		[FieldOffset(Offset = "0x18")]
		public string _newRecipeName;

		// Token: 0x04003415 RID: 13333
		[Token(Token = "0x4003415")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<CookingRecipe> _recipes;

		// Token: 0x04003416 RID: 13334
		[Token(Token = "0x4003416")]
		[FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("_waterRecipe")]
		[SerializeField]
		private StatRecipe _dirtyWaterRecipe;

		// Token: 0x04003417 RID: 13335
		[Token(Token = "0x4003417")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private StatRecipe _cleanWaterRecipe;
	}
}
