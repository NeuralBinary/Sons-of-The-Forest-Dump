using System;
using Il2CppDummyDll;
using Sons.Crafting.Structures;
using UnityEngine;

namespace Sons.Crafting
{
	// Token: 0x020006C3 RID: 1731
	[Token(Token = "0x20006C3")]
	[Serializable]
	public class BlueprintBookPageData
	{
		// Token: 0x06002DB6 RID: 11702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DB6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public BlueprintBookPageData()
		{
		}

		// Token: 0x04002808 RID: 10248
		[Token(Token = "0x4002808")]
		[FieldOffset(Offset = "0x10")]
		public Texture2D _pageImage;

		// Token: 0x04002809 RID: 10249
		[Token(Token = "0x4002809")]
		[FieldOffset(Offset = "0x18")]
		public string _pageTitleLocalizationId;

		// Token: 0x0400280A RID: 10250
		[Token(Token = "0x400280A")]
		[FieldOffset(Offset = "0x20")]
		public StructureRecipe _topRecipe;

		// Token: 0x0400280B RID: 10251
		[Token(Token = "0x400280B")]
		[FieldOffset(Offset = "0x28")]
		public StructureRecipe _bottomRecipe;
	}
}
