using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace TheForest.Items.Craft
{
	// Token: 0x020004C7 RID: 1223
	[Token(Token = "0x20004C7")]
	[AddComponentMenu("Items/Craft/Recipe Book")]
	public class RecipeBook : MonoBehaviour
	{
		// Token: 0x06001F6D RID: 8045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F6D")]
		[Address(RVA = "0x2D2FC70", Offset = "0x2D2EC70", VA = "0x182D2FC70")]
		private void Start()
		{
		}

		// Token: 0x06001F6E RID: 8046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F6E")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private void OnDeserialized()
		{
		}

		// Token: 0x06001F6F RID: 8047 RVA: 0x000090D8 File Offset: 0x000072D8
		[Token(Token = "0x6001F6F")]
		[Address(RVA = "0x2D2F920", Offset = "0x2D2E920", VA = "0x182D2F920")]
		public bool AddRecipe(Recipe recipe)
		{
			return default(bool);
		}

		// Token: 0x06001F70 RID: 8048 RVA: 0x000090F0 File Offset: 0x000072F0
		[Token(Token = "0x6001F70")]
		[Address(RVA = "0x2D2F830", Offset = "0x2D2E830", VA = "0x182D2F830")]
		public bool AddRecipe(int recipeId)
		{
			return default(bool);
		}

		// Token: 0x06001F71 RID: 8049 RVA: 0x00009108 File Offset: 0x00007308
		[Token(Token = "0x6001F71")]
		[Address(RVA = "0x2D2FB30", Offset = "0x2D2EB30", VA = "0x182D2FB30")]
		public bool RemoveRecipe(Recipe recipe)
		{
			return default(bool);
		}

		// Token: 0x06001F72 RID: 8050 RVA: 0x00009120 File Offset: 0x00007320
		[Token(Token = "0x6001F72")]
		[Address(RVA = "0x2D2FBD0", Offset = "0x2D2EBD0", VA = "0x182D2FBD0")]
		public bool RemoveRecipe(int recipeId)
		{
			return default(bool);
		}

		// Token: 0x06001F73 RID: 8051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F73")]
		[Address(RVA = "0x2D2FA20", Offset = "0x2D2EA20", VA = "0x182D2FA20")]
		private void RefreshCache()
		{
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06001F74 RID: 8052 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F75 RID: 8053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000465")]
		public IEnumerable<Recipe> AvailableRecipesCache
		{
			[Token(Token = "0x6001F74")]
			[Address(RVA = "0x541210", Offset = "0x540210", VA = "0x180541210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F75")]
			[Address(RVA = "0x541250", Offset = "0x540250", VA = "0x180541250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06001F76 RID: 8054 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F77 RID: 8055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000466")]
		public IEnumerable<Recipe> AvailableUpgradeCache
		{
			[Token(Token = "0x6001F76")]
			[Address(RVA = "0x541220", Offset = "0x540220", VA = "0x180541220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F77")]
			[Address(RVA = "0x541260", Offset = "0x540260", VA = "0x180541260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001F78 RID: 8056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F78")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public RecipeBook()
		{
		}

		// Token: 0x04001D0E RID: 7438
		[Token(Token = "0x4001D0E")]
		[FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("_receipeDatabase")]
		public RecipeDatabase _recipeDatabase;

		// Token: 0x04001D0F RID: 7439
		[Token(Token = "0x4001D0F")]
		[FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("_availableReceipes")]
		public List<int> _availableRecipes;
	}
}
