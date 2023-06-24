using System;
using Il2CppDummyDll;
using Sons.Items.Core;

namespace Sons.Crafting.Structures
{
	// Token: 0x020006E8 RID: 1768
	[Token(Token = "0x20006E8")]
	[Serializable]
	public class StructureCraftingRecipeIngredient
	{
		// Token: 0x06002ED0 RID: 11984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ED0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public StructureCraftingRecipeIngredient()
		{
		}

		// Token: 0x04002897 RID: 10391
		[Token(Token = "0x4002897")]
		[FieldOffset(Offset = "0x10")]
		[ItemIdPicker(true)]
		public int ItemId;

		// Token: 0x04002898 RID: 10392
		[Token(Token = "0x4002898")]
		[FieldOffset(Offset = "0x14")]
		public int Count;
	}
}
