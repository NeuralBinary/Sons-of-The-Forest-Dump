using System;
using Il2CppDummyDll;
using Sons.Crafting.Structures;
using UnityEngine;

namespace Sons.Crafting
{
	// Token: 0x020007B8 RID: 1976
	[Token(Token = "0x20007B8")]
	[Serializable]
	public class BlueprintBookPageData
	{
		// Token: 0x0600343D RID: 13373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600343D")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public BlueprintBookPageData()
		{
		}

		// Token: 0x04002D34 RID: 11572
		[Token(Token = "0x4002D34")]
		[FieldOffset(Offset = "0x10")]
		public Texture2D _pageImage;

		// Token: 0x04002D35 RID: 11573
		[Token(Token = "0x4002D35")]
		[FieldOffset(Offset = "0x18")]
		public string _pageTitleLocalizationId;

		// Token: 0x04002D36 RID: 11574
		[Token(Token = "0x4002D36")]
		[FieldOffset(Offset = "0x20")]
		public StructureRecipe _topRecipe;

		// Token: 0x04002D37 RID: 11575
		[Token(Token = "0x4002D37")]
		[FieldOffset(Offset = "0x28")]
		public StructureRecipe _bottomRecipe;
	}
}
