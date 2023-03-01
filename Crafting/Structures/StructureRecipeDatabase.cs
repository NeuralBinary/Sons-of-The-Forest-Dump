using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Crafting.Structures
{
	// Token: 0x020007E5 RID: 2021
	[Token(Token = "0x20007E5")]
	[CreateAssetMenu(fileName = "StructureRecipeDatabase", menuName = "Sons/Crafting/StructureRecipeDatabase")]
	public class StructureRecipeDatabase : ScriptableObject
	{
		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06003571 RID: 13681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006E8")]
		public List<StructureRecipe> Recipes
		{
			[Token(Token = "0x6003571")]
			[Address(RVA = "0x541230", Offset = "0x540230", VA = "0x180541230")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003572 RID: 13682 RVA: 0x0000F5B8 File Offset: 0x0000D7B8
		[Token(Token = "0x6003572")]
		[Address(RVA = "0x2EA5A20", Offset = "0x2EA4A20", VA = "0x182EA5A20")]
		public int GetNextId()
		{
			return default(int);
		}

		// Token: 0x06003573 RID: 13683 RVA: 0x0000F5D0 File Offset: 0x0000D7D0
		[Token(Token = "0x6003573")]
		[Address(RVA = "0x2EA5B40", Offset = "0x2EA4B40", VA = "0x182EA5B40")]
		public bool TryGetRecipeById(int id, out StructureRecipe recipe)
		{
			return default(bool);
		}

		// Token: 0x06003574 RID: 13684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003574")]
		[Address(RVA = "0x2EA5C80", Offset = "0x2EA4C80", VA = "0x182EA5C80")]
		public StructureRecipeDatabase()
		{
		}

		// Token: 0x04002DED RID: 11757
		[Token(Token = "0x4002DED")]
		private const string RecipesPath = "Assets/Sons/Crafting/Structures/Recipes/";

		// Token: 0x04002DEE RID: 11758
		[Token(Token = "0x4002DEE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Object _prefabProcessor;

		// Token: 0x04002DEF RID: 11759
		[Token(Token = "0x4002DEF")]
		[FieldOffset(Offset = "0x20")]
		public string _newRecipeName;

		// Token: 0x04002DF0 RID: 11760
		[Token(Token = "0x4002DF0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<StructureRecipe> _recipes;
	}
}
