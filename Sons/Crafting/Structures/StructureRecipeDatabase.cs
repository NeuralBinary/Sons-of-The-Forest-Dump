using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Crafting.Structures
{
	// Token: 0x020006F2 RID: 1778
	[Token(Token = "0x20006F2")]
	[CreateAssetMenu(fileName = "StructureRecipeDatabase", menuName = "Sons/Crafting/StructureRecipeDatabase")]
	public class StructureRecipeDatabase : ScriptableObject
	{
		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06002F0C RID: 12044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700065D")]
		public List<StructureRecipe> Recipes
		{
			[Token(Token = "0x6002F0C")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002F0D RID: 12045 RVA: 0x0000DFF8 File Offset: 0x0000C1F8
		[Token(Token = "0x6002F0D")]
		[Address(RVA = "0x3457CE0", Offset = "0x34562E0", VA = "0x183457CE0")]
		public int GetNextId()
		{
			return 0;
		}

		// Token: 0x06002F0E RID: 12046 RVA: 0x0000E010 File Offset: 0x0000C210
		[Token(Token = "0x6002F0E")]
		[Address(RVA = "0x3457E60", Offset = "0x3456460", VA = "0x183457E60")]
		public bool TryGetRecipeById(int id, out StructureRecipe recipe)
		{
			return default(bool);
		}

		// Token: 0x06002F0F RID: 12047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F0F")]
		[Address(RVA = "0x3458050", Offset = "0x3456650", VA = "0x183458050")]
		public StructureRecipeDatabase()
		{
		}

		// Token: 0x040028D9 RID: 10457
		[Token(Token = "0x40028D9")]
		private const string RecipesPath = "Assets/Sons/Crafting/Structures/Recipes/";

		// Token: 0x040028DA RID: 10458
		[Token(Token = "0x40028DA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UnityEngine.Object _prefabProcessor;

		// Token: 0x040028DB RID: 10459
		[Token(Token = "0x40028DB")]
		[FieldOffset(Offset = "0x20")]
		public string _newRecipeName;

		// Token: 0x040028DC RID: 10460
		[Token(Token = "0x40028DC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<StructureRecipe> _recipes;
	}
}
