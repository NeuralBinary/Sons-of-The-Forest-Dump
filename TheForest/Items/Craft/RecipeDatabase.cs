using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace TheForest.Items.Craft
{
	// Token: 0x020004C9 RID: 1225
	[Token(Token = "0x20004C9")]
	public class RecipeDatabase : ScriptableObject
	{
		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06001F7E RID: 8062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000467")]
		public static Recipe[] Recipes
		{
			[Token(Token = "0x6001F7E")]
			[Address(RVA = "0x2D300F0", Offset = "0x2D2F0F0", VA = "0x182D300F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F7F RID: 8063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F7F")]
		[Address(RVA = "0x2D30000", Offset = "0x2D2F000", VA = "0x182D30000")]
		public void OnEnable()
		{
		}

		// Token: 0x06001F80 RID: 8064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F80")]
		[Address(RVA = "0x539C30", Offset = "0x538C30", VA = "0x180539C30")]
		public RecipeDatabase()
		{
		}

		// Token: 0x04001D14 RID: 7444
		[Token(Token = "0x4001D14")]
		[FieldOffset(Offset = "0x18")]
		[HideInInspector]
		[SerializeField]
		private int _lastId;

		// Token: 0x04001D15 RID: 7445
		[Token(Token = "0x4001D15")]
		[FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("_receipes")]
		public Recipe[] _recipes;

		// Token: 0x04001D16 RID: 7446
		[Token(Token = "0x4001D16")]
		[FieldOffset(Offset = "0x0")]
		public static RecipeDatabase _instance;
	}
}
