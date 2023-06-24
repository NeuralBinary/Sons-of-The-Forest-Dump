using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace TheForest.Items.Craft
{
	// Token: 0x020004BC RID: 1212
	[Token(Token = "0x20004BC")]
	[AddComponentMenu("Items/Craft/Recipe Book")]
	public class RecipeBook : MonoBehaviour
	{
		// Token: 0x06001FD1 RID: 8145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FD1")]
		[Address(RVA = "0x330C960", Offset = "0x330AF60", VA = "0x18330C960")]
		private void Start()
		{
		}

		// Token: 0x06001FD2 RID: 8146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FD2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void OnDeserialized()
		{
		}

		// Token: 0x06001FD3 RID: 8147 RVA: 0x00009438 File Offset: 0x00007638
		[Token(Token = "0x6001FD3")]
		[Address(RVA = "0x330CBD0", Offset = "0x330B1D0", VA = "0x18330CBD0")]
		public bool AddRecipe(Recipe recipe)
		{
			return default(bool);
		}

		// Token: 0x06001FD4 RID: 8148 RVA: 0x00009450 File Offset: 0x00007650
		[Token(Token = "0x6001FD4")]
		[Address(RVA = "0x330CD00", Offset = "0x330B300", VA = "0x18330CD00")]
		public bool AddRecipe(int recipeId)
		{
			return default(bool);
		}

		// Token: 0x06001FD5 RID: 8149 RVA: 0x00009468 File Offset: 0x00007668
		[Token(Token = "0x6001FD5")]
		[Address(RVA = "0x330CE30", Offset = "0x330B430", VA = "0x18330CE30")]
		public bool RemoveRecipe(Recipe recipe)
		{
			return default(bool);
		}

		// Token: 0x06001FD6 RID: 8150 RVA: 0x00009480 File Offset: 0x00007680
		[Token(Token = "0x6001FD6")]
		[Address(RVA = "0x330CF10", Offset = "0x330B510", VA = "0x18330CF10")]
		public bool RemoveRecipe(int recipeId)
		{
			return default(bool);
		}

		// Token: 0x06001FD7 RID: 8151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FD7")]
		[Address(RVA = "0x330CFF0", Offset = "0x330B5F0", VA = "0x18330CFF0")]
		private void RefreshCache()
		{
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06001FD8 RID: 8152 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FD9 RID: 8153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000474")]
		public IEnumerable<Recipe> AvailableRecipesCache
		{
			[Token(Token = "0x6001FD8")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FD9")]
			[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06001FDA RID: 8154 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FDB RID: 8155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000475")]
		public IEnumerable<Recipe> AvailableUpgradeCache
		{
			[Token(Token = "0x6001FDA")]
			[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FDB")]
			[Address(RVA = "0x5B2F00", Offset = "0x5B1500", VA = "0x1805B2F00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001FDC RID: 8156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FDC")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public RecipeBook()
		{
		}

		// Token: 0x04001D4A RID: 7498
		[Token(Token = "0x4001D4A")]
		[FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("_receipeDatabase")]
		public RecipeDatabase _recipeDatabase;

		// Token: 0x04001D4B RID: 7499
		[Token(Token = "0x4001D4B")]
		[FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("_availableReceipes")]
		public List<int> _availableRecipes;
	}
}
