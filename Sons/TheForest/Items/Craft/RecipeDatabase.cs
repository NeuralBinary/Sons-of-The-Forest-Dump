using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace TheForest.Items.Craft
{
	// Token: 0x020004BE RID: 1214
	[Token(Token = "0x20004BE")]
	public class RecipeDatabase : ScriptableObject
	{
		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06001FE2 RID: 8162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000476")]
		public static Recipe[] Recipes
		{
			[Token(Token = "0x6001FE2")]
			[Address(RVA = "0x330D580", Offset = "0x330BB80", VA = "0x18330D580")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FE3")]
		[Address(RVA = "0x330D5D0", Offset = "0x330BBD0", VA = "0x18330D5D0")]
		public void OnEnable()
		{
		}

		// Token: 0x06001FE4 RID: 8164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FE4")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public RecipeDatabase()
		{
		}

		// Token: 0x04001D50 RID: 7504
		[Token(Token = "0x4001D50")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		private int _lastId;

		// Token: 0x04001D51 RID: 7505
		[Token(Token = "0x4001D51")]
		[FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("_receipes")]
		public Recipe[] _recipes;

		// Token: 0x04001D52 RID: 7506
		[Token(Token = "0x4001D52")]
		[FieldOffset(Offset = "0x0")]
		public static RecipeDatabase _instance;
	}
}
